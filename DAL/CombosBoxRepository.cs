using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CombosBoxRepository: BaseDatos
    {
        OracleCommand cmd;

        public CombosBoxRepository() { }

        public List<T> GetEntities<T>(string tableName) where T : IBaseEntity, new()
        {
            var list = new List<T>();
            string _sql = $"SELECT * FROM {tableName}";
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
                            list.Add(Map<T>(reader));
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new Exception($"Error al ejecutar la consulta para obtener datos de la tabla {tableName}", ex);
            }
            finally
            {
                CerrarConexion();
            }
            return list;
        }

        private T Map<T>(OracleDataReader reader) where T : IBaseEntity, new()
        {
            T entity = new T
            {
                Id = reader.GetString(0),
                Descripcion = reader.GetString(1)
            };
            return entity;
        }   

    }
}
