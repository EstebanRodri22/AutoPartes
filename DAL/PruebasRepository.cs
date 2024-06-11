using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class PruebasRepository : BaseDatos
    {
        OracleCommand cmd;

        public PruebasRepository()
        {
            cmd = new OracleCommand();
        }

        public DataTable getVentas(string procedureName)
        {
            DataTable ventasTable = new DataTable();
            try
            {
                AbrirConexion();

                using (cmd = new OracleCommand(procedureName, Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter cursorParameter = cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor);
                    cursorParameter.Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(ventasTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error if needed
                throw new Exception("Estamos teniendo problemas al obtener las ventas.", ex);
            }
            finally
            {
                CerrarConexion();
            }

            return ventasTable;
        }

    }
}
