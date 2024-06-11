using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepuestoRepository:BaseDatos
    {
        OracleCommand cmd;

        public RepuestoRepository()
        {
            
        }

        public string registrarPiezaElectrica(PiezaElectrica pieza, string procedureName)
        {
            string nuevoInventario = GenerarConsecutivo("administrador.Inventario_Repuesto", "id_inventario");
            string nuevoRepuestoElectrico = GenerarConsecutivo("administrador.PIEZAELECTRICA", "ID_piezaElectrica");
            string nuevoRepuesto = GenerarConsecutivo("administrador.repuestos", "id_repuesto");

            try
            {

                using (cmd = new OracleCommand(procedureName, Connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    

                    
                    // Parámetros de entrada
                    cmd.Parameters.Add("p_id_piezaelectrica", OracleDbType.Varchar2).Value = nuevoRepuestoElectrico;
                    cmd.Parameters.Add("p_voltaje", OracleDbType.Varchar2).Value = pieza.voltaje;
                    cmd.Parameters.Add("p_resistencia", OracleDbType.Varchar2).Value = pieza.resistencia;
                    cmd.Parameters.Add("p_id_repuesto", OracleDbType.Varchar2).Value = nuevoRepuesto;
                    cmd.Parameters.Add("p_precio", OracleDbType.Int32).Value = pieza.Precio;
                    cmd.Parameters.Add("p_detalle", OracleDbType.Varchar2).Value = pieza.Detalles;
                    cmd.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = pieza.cantidad;
                    cmd.Parameters.Add("p_id_inventario", OracleDbType.Varchar2).Value = nuevoInventario; //concecutivo
                    cmd.Parameters.Add("p_id_categoria", OracleDbType.Varchar2).Value = pieza.categoria.Id;
                    cmd.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = pieza.automovil.Placa;

                    AbrirConexion();

                    cmd.ExecuteNonQuery();

                    return $"Pieza Agregada Exitosamente ";
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Tuvimos un fallo al registrar la pieza " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public string registrarPiezaMecanica(PiezaMecanica pieza, string procedureName)
        {
            string nuevoInventario = GenerarConsecutivo("administrador.Inventario_Repuesto", "id_inventario");
            string nuevoRepuestoMecanico = GenerarConsecutivo("administrador.PIEZAMECANICA", "ID_piezaMecanica");
            string nuevoRepuesto = GenerarConsecutivo("administrador.repuestos", "id_repuesto");

            try
            {

                using (cmd = new OracleCommand(procedureName, Connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;



                    // Parámetros de entrada
                    cmd.Parameters.Add("p_id_piezaelectrica", OracleDbType.Varchar2).Value = nuevoRepuestoMecanico;
                    cmd.Parameters.Add("p_durabilidad", OracleDbType.Varchar2).Value = pieza.Durabilidad;
                    cmd.Parameters.Add("p_material", OracleDbType.Varchar2).Value = pieza.Material;
                    cmd.Parameters.Add("p_dimensiones", OracleDbType.Varchar2).Value = pieza.Dimensiones;
                    cmd.Parameters.Add("p_id_repuesto", OracleDbType.Varchar2).Value = nuevoRepuesto;
                    cmd.Parameters.Add("p_precio", OracleDbType.Int32).Value = pieza.Precio;
                    cmd.Parameters.Add("p_detalle", OracleDbType.Varchar2).Value = pieza.Detalles;
                    cmd.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = pieza.cantidad;
                    cmd.Parameters.Add("p_id_inventario", OracleDbType.Varchar2).Value = nuevoInventario; //concecutivo
                    cmd.Parameters.Add("p_id_categoria", OracleDbType.Varchar2).Value = pieza.categoria.Id;
                    cmd.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = pieza.automovil.Placa;

                    AbrirConexion();

                    cmd.ExecuteNonQuery();

                    return $"Pieza Agregada Exitosamente ";
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Tuvimos un fallo al registrar la pieza " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }


        public DataTable GetRepuestoById(string idRepuesto)
        {
            string query = "SELECT r.id_repuesto, c.name_categoria, r.precio, r.detalle FROM repuestos r JOIN categorias c ON (r.id_categoria = c.id_categoria) WHERE (id_repuesto = :id)";
            cmd = new OracleCommand(query, Connection);
            cmd.Parameters.Add(":id", idRepuesto);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable repuestoTable = new DataTable();
            adapter.Fill(repuestoTable);

            return repuestoTable;
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

            AbrirConexion();
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

            CerrarConexion();
            return ultimoConsecutivo;
        }
    }
}
