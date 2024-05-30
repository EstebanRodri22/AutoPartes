using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Movimientos
    {
        private string NoFactura {  get; set; }
        private int Cantidad { get; set;}
        private DateTime FechaFactura { get; set; }

        private double ValorFactura { get; set; }

        public Movimientos(string noFactura, int cantidad, DateTime fechaFactura, double valorFactura)
        {
            NoFactura = noFactura;
            Cantidad = cantidad;
            FechaFactura = fechaFactura;
            ValorFactura = valorFactura;
        }
    }
}
