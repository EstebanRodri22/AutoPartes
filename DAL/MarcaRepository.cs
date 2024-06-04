using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class MarcaRepository :BaseDatos
    {
        OracleCommand cmd;

        public MarcaRepository()
        {
            cmd = new OracleCommand();
        }

        public List<Marca> GetAll()
        {
            var list = new List<Marca>();
            string _sql = "SELECT * FROM marcas";

            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.CommandText = _sql;
                cmd.Connection = Connection;

                AbrirConexion();
                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Map(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Maneja la excepción si es necesario
                    throw new Exception("Error al ejecutar la consulta para obtener todas las marcas.", ex);
                }
                finally
                {
                    CerrarConexion();
                }
            }

            return list;
        }

        private Marca Map(OracleDataReader reader)
        {
            Marca marca = new Marca();
            marca.IdMarca = reader.GetString(0);
            marca.name_marca = reader.GetString(1);
            return marca;
        }
    }
}
