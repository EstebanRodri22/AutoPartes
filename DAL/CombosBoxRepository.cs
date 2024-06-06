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

        public List<Marca> GetMarcaList()
        {
            var list = new List<Marca>();
            string _sql = "SELECT * FROM Marcas";
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
                            list.Add(MapMarca(reader));
                        }
                    }
                }
            }
            catch(OracleException ex) 
            {
                throw new Exception("Error al ejecutar la consulta para obtener todas las marcas", ex);
            }
            finally
            {
                CerrarConexion();
            }
            return list;
        }

        public List<TipoDocumento> GetTiposDocumento()
        {
            var list = new List<TipoDocumento>();
            string _sql = "SELECT * FROM Tipo_documento";
            try
            {
                AbrirConexion();
                using(cmd = new OracleCommand())
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

            }catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta para obtener todas los tipos de documentos", ex);
            }
            finally
            {
                CerrarConexion();
            }
            return list;
        }

        private TipoDocumento Map(OracleDataReader reader)
        {
            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.id_documento = reader.GetString(0);
            tipoDocumento.descripcion = reader.GetString(1);
            return tipoDocumento;
        }

        private Marca MapMarca(OracleDataReader reader)
        {
            Marca marca = new Marca();
            marca.IdMarca = reader.GetString(0);
            marca.name_marca = reader.GetString(1);
            return marca;
        }
    }
}
