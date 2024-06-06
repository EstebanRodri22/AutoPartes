using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComprasRepository : BaseDatos
    {
        OracleCommand cmd;

        public ComprasRepository()
        {
        }

        public string InsertarCompra(Compras compra, string ProcedureName)
        {
            string nuevoNoFactura = GenerarConsecutivo();
            try
            {
                AbrirConexion();
                using(cmd = new OracleCommand(ProcedureName, Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parametros de Entrada
                    cmd.Parameters.Add("p_No_Factura", OracleDbType.Varchar2).Value = nuevoNoFactura;
                    cmd.Parameters.Add("p_Cantidad", OracleDbType.Int32).Value = 1;
                    cmd.Parameters.Add("P_valor_Factura", OracleDbType.Double).Value = compra.ValorFactura;
                    cmd.Parameters.Add("p_observaciones", OracleDbType.Varchar2).Value = compra.observaciones;
                    cmd.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = compra.automovil.Placa;
                    cmd.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = compra.proveedor.identificacion;

                    cmd.ExecuteNonQuery();

                    return $"se Inserto la Compra corectamente ";
                }

            }
            catch(OracleException ex)
            {
                throw new Exception("Error al insertar la Compra: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }

             
        }

        public string GenerarConsecutivo()
        {
            int ultimoConsecutivo = ObtenerUltimoConsecutivo();
            int nuevoConsecutivo = ultimoConsecutivo + 1;
            return nuevoConsecutivo.ToString(); // Retorna el nuevo consecutivo como string
        }


        private int ObtenerUltimoConsecutivo()
        {
            int ultimoConsecutivo = 0;

            AbrirConexion();
                // Consulta para obtener el último consecutivo
                string sql = "SELECT MAX(CAST(No_Factura AS INT)) from administrador.movimientos";

                using ( cmd = new OracleCommand(sql, Connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ultimoConsecutivo = Convert.ToInt32(result);
                    }
                }

            return ultimoConsecutivo;
        }
    }
}
