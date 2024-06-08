using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class RepuestosServices
    {
        private RepuestoRepository repuesto = new RepuestoRepository();

        public DataTable GetRepuestoById(string idRepuesto)
        {
            DataTable repuestosTable = repuesto.GetRepuestoById(idRepuesto);

            if (repuestosTable.Rows.Count == 0)
            {
                throw new Exception("El repuesto con el ID " + idRepuesto + " no se encontró en la base de datos.");
            }

            return repuestosTable;
        }

        public string actualizarNoFactura(string idRepuesto, string NoFactura)
        {
            return repuesto.actualizarNoFactura(idRepuesto, NoFactura);
        }
    }
}
