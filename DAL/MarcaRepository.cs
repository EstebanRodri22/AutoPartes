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
            string _sql = "select * from marcas";
            cmd.CommandText = _sql;
            cmd.Connection = con;

            // Agrega los parámetros


            AbrirConexion();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Map(reader));
            }
            CerrarConexion();
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
