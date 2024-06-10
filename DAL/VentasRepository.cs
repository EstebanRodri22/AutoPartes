using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentasRepository : BaseDatos
    {
        OracleCommand cmd;

        public VentasRepository()
        {

        }
        public DataTable getVentas(string procedureName)
        {
            DataTable ventas = new DataTable();
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, Connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    OracleParameter cursorParameter = command.Parameters.Add("p_cursor", OracleDbType.RefCursor);
                    cursorParameter.Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(ventas);
                    }
                }
                return ventas;
            }
            catch (OracleException ex)
            {
                throw new Exception($"Error al recuperar las ventas" + ex.Message);
            }
        }

        public string registrarVentas(Ventas venta, List<RepuestoVendido> repuestosVendidos, string ProcedureName)
        {
            
            AbrirConexion();
            OracleTransaction transaction = Connection.BeginTransaction();
            string noFactura = GenerarConsecutivo("administrador.movimientos", "No_factura");
            string id_garantia = GenerarConsecutivo("administrador.info_garantia", "id_garantia");
            try
            {
                
                using (cmd = new OracleCommand(ProcedureName, Connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parametros de Entrada
                    cmd.Parameters.Add("p_No_Factura", OracleDbType.Varchar2).Value = noFactura;
                    cmd.Parameters.Add("p_CantidadMovimientos", OracleDbType.Int64).Value = venta.Cantidad;
                    cmd.Parameters.Add("P_valor_Factura", OracleDbType.Double).Value = venta.ValorFactura;
                    cmd.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = venta.Cliente.identificacion;
                    cmd.Parameters.Add("p_Id_garantia", OracleDbType.Varchar2).Value = id_garantia;
                    cmd.Parameters.Add("p_fechaFin", OracleDbType.Date).Value = venta.InfoGarantia.FechaFin;
                    cmd.Parameters.Add("p_detalles", OracleDbType.Varchar2).Value = venta.InfoGarantia.detalles;
                    cmd.ExecuteNonQuery();

                    foreach (var repuesto in repuestosVendidos)
                    {
                        // Verificar stock disponible
                        string verificarStockQuery = "SELECT cantidad FROM Inventario_Repuesto WHERE id_repuesto = :IdRepuesto";
                        OracleCommand cmdVerificarStock = new OracleCommand(verificarStockQuery, Connection);
                        cmdVerificarStock.Parameters.Add(new OracleParameter(":IdRepuesto", repuesto.idRepuesto));
                        int cantidadDisponible = Convert.ToInt32(cmdVerificarStock.ExecuteScalar());

                        if (cantidadDisponible < repuesto.cantidad)
                        {
                            throw new Exception("No hay suficiente stock disponible para el repuesto con ID " + repuesto.idRepuesto);

                        }
                        string insertDetalleQuery = @"
                                        INSERT INTO DetalleVentas (id_detalle,No_Factura, id_repuesto, cantidad) 
                                        VALUES (:id_detalle,:No_factura, :IdRepuesto, :Cantidad)";

                        
                        //insertar detalle venta
                        OracleCommand cmdInsertDetalle = new OracleCommand(insertDetalleQuery, Connection);
                        cmdInsertDetalle.Parameters.Add(new OracleParameter("id_detalle", GenerarConsecutivo("administrador.detalleventas", "id_detalle")));
                        cmdInsertDetalle.Parameters.Add(new OracleParameter(":No_factura", noFactura));
                        cmdInsertDetalle.Parameters.Add(new OracleParameter(":IdRepuesto", repuesto.idRepuesto));
                        cmdInsertDetalle.Parameters.Add(new OracleParameter(":Cantidad", repuesto.cantidad));
                        cmdInsertDetalle.ExecuteNonQuery();

                        // Actualizar Inventario
                        string updateInventarioQuery = "UPDATE Inventario_Repuesto SET cantidad = cantidad - :Cantidad WHERE id_repuesto = :IdRepuesto";
                        OracleCommand cmdUpdateInventario = new OracleCommand(updateInventarioQuery, Connection);
                        cmdUpdateInventario.Parameters.Add(new OracleParameter(":Cantidad", repuesto.cantidad));
                        cmdUpdateInventario.Parameters.Add(new OracleParameter(":IdRepuesto", repuesto.idRepuesto));
                        cmdUpdateInventario.ExecuteNonQuery();

                    }
                    transaction.Commit();
                    return $"se Inserto la venta corectamente ";

                }
            }
            catch (OracleException ex)
            {
                transaction.Rollback();
                throw new Exception($"Error al ejecutar el registro de la venta", ex);
            }
            finally
            {
                CerrarConexion();

            }
        }

        public string GenerarConsecutivo(string tabla, string columna)
        {
            int ultimoConsecutivo = ObtenerUltimoConsecutivo(tabla, columna);
            int nuevoConsecutivo = ultimoConsecutivo + 1;
            return nuevoConsecutivo.ToString(); // Retorna el nuevo consecutivo como string
        }

        private int ObtenerUltimoConsecutivo(string tabla, string columna)
        {
            int ultimoConsecutivo = 0;

  
            // Consulta para obtener el último consecutivo
            string sql = $"SELECT MAX(CAST({columna} AS INT)) from {tabla}";

            using (cmd = new OracleCommand(sql, Connection))
            {
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    ultimoConsecutivo = Convert.ToInt32(result);
                }
            }

            return ultimoConsecutivo;
        }
    }
}
