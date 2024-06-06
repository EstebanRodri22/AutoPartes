using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Compras : Movimientos
    {
        public string observaciones { get; set; }

        public Proveedor proveedor { get; set; }

        public Automovil automovil { get; set; }
        public Compras() { }

        public Compras(string noFactura, int cantidad, DateTime fechaFactura, double valorFactura) : base(noFactura, cantidad, fechaFactura, valorFactura)
        {
        }

        
        

    }
}
