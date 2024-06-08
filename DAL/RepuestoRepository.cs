using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepuestoRepository:BaseDatos
    {
        OracleCommand cmd;

        public DataTable GetRepuestoById(string idRepuesto)
        {
            string query = "SELECT r.id_repuesto, c.name_categoria, r.precio, r.detalle, r.stock FROM repuestos r JOIN categorias c ON (r.id_categoria = c.id_categoria) WHERE (id_repuesto = :id)";
            cmd = new OracleCommand(query, Connection);
            cmd.Parameters.Add(":id", idRepuesto);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable repuestoTable = new DataTable();
            adapter.Fill(repuestoTable);

            return repuestoTable;
        }
    }
}
