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

        public DataTable getDataTable(string proceduraName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                AbrirConexion();

                using (cmd = new OracleCommand(proceduraName, Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter cursorParameter = cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor);
                    cursorParameter.Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error if needed
                throw new Exception("Estamos teniendo problemas al obtener las compras.", ex);
            }
            finally
            {
                CerrarConexion();
            }

            return dataTable;
        }
       

    }
}
