using DAL;
using ENTITY;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class VentasServices
    {
        VentasRepository ventasRepository;
        public VentasServices() { ventasRepository = new VentasRepository(); }

        public string obtenerNoFactura(string tabla, string columna)
        {
            return ventasRepository.GenerarConsecutivo(tabla, columna);
        }

        public string registrarVentas(Ventas venta,List<RepuestoVendido> repuestos, string ProcedureName)
        {
            try
            {
                return ventasRepository.registrarVentas(venta, repuestos,ProcedureName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }
    }
}
