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
            string _sql = $"select a.placa, m.nombre_marca,m.id_marca, a.modelo, a.vin, a.id_registro, a.no_factura " +
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
                throw new Exception($"Tenemos Problemas al ejecutar la consulta para obtener los Automoviles", ex);
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

            Marca marca = new Marca
            {
                Id = reader.GetString(2),
                Descripcion = reader.GetString(1)
            };


            automovil.Placa = reader.GetString(0);
            automovil.Modelo = reader.GetString(3);
            automovil.VIN = reader.GetString(4);
            automovil.Marca = marca;
            
            if(!reader.IsDBNull(5))
            {
                automovil.inventario.IdRegistro = reader.GetString(5);
            }
            else
            {
                automovil.inventario.IdRegistro = "No se ha registrado";
            }
            if(!reader.IsDBNull(6))     //no deberia no tener una compra, es mientras se prueba
            { 
                automovil.NoFactura = reader.GetString(6);
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
                throw new Exception("Tenemos Problemas al insertar el automovil: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
            

            
        }
    }
}
