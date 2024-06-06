using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Movimientos
    {
        public string NoFactura {  get; set; }
        public int Cantidad { get; set;}
        public DateTime FechaFactura { get; set; }

        public double ValorFactura { get; set; }

        public Movimientos() { }

        

        public Movimientos(string noFactura, int cantidad, DateTime fechaFactura, double valorFactura)
        {
            NoFactura = noFactura;
            Cantidad = cantidad;
            FechaFactura = fechaFactura;
            ValorFactura = valorFactura;
        }
    }
}
