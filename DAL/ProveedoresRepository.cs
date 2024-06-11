﻿using ENTITY;
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
                    command.Parameters.Add("p_idtipodocumento", OracleDbType.Varchar2).Value = proveedor.TipoDocumento.Id;
                    
                    command.ExecuteNonQuery();

                    return $"se agrego a {proveedor.primerNombre} corectamente ";
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Intente nuevamente insertar el proveedor: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        
    }
}
