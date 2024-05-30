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
                                "Password=oracle";
        public BaseDatos()
        {
            con = new OracleConnection(cadenConexion);
        }
        public bool AbrirConexion()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                return true;
            }
            return false;
        }

        public void CerrarConexion()
        {
            con.Close();
        }
    }
}
