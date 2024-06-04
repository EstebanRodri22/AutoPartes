using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepository : BaseDatos
    {
        public bool Login(string username, string password )
        {
            
            AbrirConexion();
            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.Connection = Connection;
                cmd.CommandType = CommandType.Text;

                
                cmd.CommandText = "SELECT * FROM Users WHERE LoginName = :username AND password = :password";

                cmd.Parameters.Add(new OracleParameter(":username", username));
                cmd.Parameters.Add(new OracleParameter(":password", password));

                OracleDataReader oracleDataReader = cmd.ExecuteReader();
                if(oracleDataReader.HasRows) 
                {
                    return true;
                }
                return false;
            }
        }
    }
}
