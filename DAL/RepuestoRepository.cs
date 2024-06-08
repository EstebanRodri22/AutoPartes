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

        public string actualizarNoFactura(string idRepuesto, string NoFactura)
        {
            string _sql = "UPDATE Repuestos SET No_Factura = :NoFactura WHERE ID_Repuesto = :ID_Repuesto";
            try
            {

                using (cmd = new OracleCommand(_sql, Connection))
                {                   
                    //añadir parametros
                    cmd.Parameters.Add(":No_Factura", NoFactura);
                    cmd.Parameters.Add(":ID_Repuesto", idRepuesto);
                    AbrirConexion();
                    cmd.ExecuteNonQuery();

                    return $"se Inserto la VENTA corectamente ";
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Error al insertar la VENTA: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable GetRepuestoById(string idRepuesto)
        {
            string query = "SELECT r.id_repuesto, c.name_categoria, r.precio, r.detalle, r.stock FROM repuestos r JOIN categorias c ON (r.id_categoria = c.id_categoria) WHERE (id_repuesto = :id)";
            cmd = new OracleCommand(query, Connection);
            cmd.Parameters.Add(":id", idRepuesto);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable repuestoTable = new DataTable();
            adapter.Fill(repuestoTable);

            return repuestoTable;
        }
    }
}
