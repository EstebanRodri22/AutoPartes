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

        public string registrarPiezaElectrica(PiezaElectrica piezaElectrica, string procedureName)
        {
            try 
            { 
                 return repuesto.registrarPiezaElectrica(piezaElectrica, procedureName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }

        public string registrarPiezaMecanica(PiezaMecanica pieza, string procedureName)
        {
            try
            {
                return repuesto.registrarPiezaMecanica(pieza, procedureName);
            }
            catch (Exception ex) 
            {
                throw new Exception("error en la capa de negocio:" + ex.Message, ex);
            }
        }

        public string generarConcecutivo(string tabla, string columna)
        {
            try
            {
                return repuesto.GenerarConsecutivo(tabla, columna);

            }catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio " + ex.Message ,ex);
            }
        }
    }
}
