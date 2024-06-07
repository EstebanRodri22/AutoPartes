using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Types;

namespace DAL
{
    public class VehiculoRepository:BaseDatos
    {
        OracleCommand cmd;
        

        public VehiculoRepository()
        {
            cmd = new OracleCommand();
            
        }

        public List<Automovil> GetAutomovils()
        {
            var list = new List<Automovil>();
            string _sql = $"select a.placa,m.nombre_marca, a.modelo, a.vin, a.id_registro, a.no_factura " +
                          $"FROM automoviles a JOIN marcas m ON (a.id_marca = m.id_marca)";
            try
            {
                AbrirConexion();
                using (cmd = new OracleCommand())
                {
                    cmd.CommandText = _sql;
                    cmd.Connection = Connection;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new Exception($"Error al ejecutar la consulta para obtener los Automoviles", ex);
            }
            finally
            {
                CerrarConexion();
            }
            return list;
        }

        private Automovil Map(OracleDataReader reader)
        {
            Automovil automovil = new Automovil();
            automovil.Placa = reader.GetString(0);
            automovil.Marca.Descripcion = reader.GetString(1);
            automovil.Modelo = reader.GetString(2);
            automovil.VIN = reader.GetString(3);
            
            
            if(!reader.IsDBNull(4))
            {
                automovil.inventario.IdRegistro = reader.GetString(4);
            }
            else
            {
                automovil.inventario.IdRegistro = "No se ha registrado";
            }
            if(!reader.IsDBNull(5))
            {
                automovil.NoFactura = reader.GetString(5);
            }
            else
            {
                automovil.NoFactura = "Sin compra";
            }


            return automovil;
            
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
                cmd.Parameters.Add(":id_marca", OracleDbType.Varchar2).Value = automovil.Marca.Id;

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
