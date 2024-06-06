using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class VehiculoRepository:BaseDatos
    {
        OracleCommand cmd;

        public VehiculoRepository()
        {
            cmd = new OracleCommand();
        }

        public string insertarAutomovil(Automovil automovil)
        {
            
            string _sql = "INSERT INTO automoviles (placa, modelo, vin, targeta_propiedad, id_marca) VALUES (:placa, :modelo, :vin, EMPTY_BLOB(), :id_marca)";
            cmd.CommandText = _sql;
            cmd.Connection = Connection;
            try
            {
                
                // Agrega los parámetros
                cmd.Parameters.Add(":placa", OracleDbType.Varchar2).Value = automovil.Placa;
                cmd.Parameters.Add(":modelo", OracleDbType.Varchar2).Value = automovil.Modelo;
                cmd.Parameters.Add(":vin", OracleDbType.Varchar2).Value = automovil.VIN;
                cmd.Parameters.Add(":id_marca", OracleDbType.Varchar2).Value = automovil.Marca.IdMarca;

                AbrirConexion();
                cmd.ExecuteNonQuery();
                return $"se agrego el automovil con placa : {automovil.Placa} corectamente ";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el automovil: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
            

            
        }
    }
}
