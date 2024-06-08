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
    public class VentasRepository : BaseDatos
    {
        OracleCommand cmd;

        public VentasRepository()
        {

        }

        public string registrarVentas(Ventas venta, string ProcedureName)
        {
            try
            {
                AbrirConexion();
                using (cmd = new OracleCommand(ProcedureName, Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parametros de Entrada
                    cmd.Parameters.Add("p_No_Factura", OracleDbType.Varchar2).Value = venta.NoFactura;
                    cmd.Parameters.Add("p_Cantidad", OracleDbType.Int32).Value = venta.Cantidad;
                    cmd.Parameters.Add("P_valor_Factura", OracleDbType.Double).Value = venta.ValorFactura;
                  // cmd.Parameters.Add("p_id_Garantia", OracleDbType.Varchar2).Value = venta.InfoGarantia.IdGarantia;
                    cmd.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = venta.Cliente.identificacion;

                    cmd.ExecuteNonQuery();

                    return $"se Inserto la venta corectamente ";
                }

            }
            catch (OracleException ex)
            {
                throw new Exception("Error al insertar la venta: " + ex.Message, ex);
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

            using (cmd = new OracleCommand(sql, Connection))
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
