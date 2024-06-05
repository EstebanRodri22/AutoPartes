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
    public class TipoDocRepository: BaseDatos
    {
        OracleCommand cmd;

        public TipoDocRepository()
        {

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
    }
}
