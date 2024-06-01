using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Compras : Movimientos
    {
        private string observaciones { get; set; }

        public Compras(string noFactura, int cantidad, DateTime fechaFactura, double valorFactura) : base(noFactura, cantidad, fechaFactura, valorFactura)
        {
        }

        
        

    }
}
