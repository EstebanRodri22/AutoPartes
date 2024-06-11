using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleVenta
    {
        public string id_detalleVenta {  get; set; }
        public int cantidad { get; set; }
        public Ventas venta { get; set; }
        public Repuesto repuesto { get; set; }

        public DetalleVenta() { }

    }
}
