using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class BaseDatos
    {
        protected OracleConnection con;
        string cadenConexion = "Data Source=localhost:1521/xepdb1;" +
                                "User Id=administrador;" +
                                "Password=oracle;";
        public BaseDatos()
        {
            con = new OracleConnection(cadenConexion);
        }
        public bool AbrirConexion()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    return true;
                }
            }
            catch (OracleException ex)
            {
                // Log the error if needed
                throw new Exception("Error al abrir la conexión con Oracle.", ex);
            }
            catch (Exception ex)
            {
                // Log the error if needed
                throw new Exception("Error general al abrir la conexión.", ex);
            }
            return false;
        }

        public void CerrarConexion()
        {
            con.Close();
        }
    }
}