using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DAL
{
    public class ProveedoresRepository : BaseDatos
    {

        OracleCommand command;

       public ProveedoresRepository()
        {
            command = new OracleCommand();
        }
        public  string insertar2(Proveedor proveedor, string procedureName)
        {
            try
            {
                AbrirConexion();

                using (command = new OracleCommand(procedureName, Connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    command.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = proveedor.identificacion;
                    command.Parameters.Add("p_primer_nombre", OracleDbType.Varchar2).Value = proveedor.primerNombre;
                    command.Parameters.Add("p_primer_apellido", OracleDbType.Varchar2).Value = proveedor.primerApellido;
                    command.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = proveedor.telefono;

                    return "Proveedor insertado exitosamente.";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el proveedor: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        
    }
}
