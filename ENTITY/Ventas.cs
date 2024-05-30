using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ventas : Movimientos
    {
        private Cliente Cliente { get; set; }
        private Repuesto Repuesto { get; set; }
        private InfoGarantia InfoGarantia { get; set; }

        public Ventas(string noFactura, int cantidad, DateTime fechaFactura, double valorFactura) : base(noFactura, cantidad, fechaFactura, valorFactura)
        {
           
        }

     
    }
}
