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

        public string obtenerNoFactura()
        {
            return ventasRepository.GenerarConsecutivo();
        }

        public string registrarVentas(Ventas venta, string ProcedureName)
        {
            try
            {
                return ventasRepository.registrarVentas(venta, ProcedureName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }
    }
}
