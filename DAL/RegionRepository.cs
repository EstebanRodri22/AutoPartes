using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class RegionRepository :BaseDatos
    {
        OracleCommand cmd;
        public RegionRepository() //clase para operar la base de datos relacional, su dml 
        {
            cmd = new OracleCommand();
        }

        public List<Region> GetAll()
        {
            var list = new List<Region>();
            string _sql = "select * from regions";
            cmd.CommandText = _sql;
            cmd.Connection = Connection;

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

        private Region Map(OracleDataReader reader)
        {
            Region region = new Region();
            region.Region_Id = reader.GetInt32(0);
            region.Region_Name = reader.GetString(1);
            return region;
        }

    }
}
