using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ventas : Movimientos
    {
        public Cliente Cliente { get; set; }

        public InfoGarantia InfoGarantia { get; set; }

        public Ventas () 
        { 
            Cliente = new Cliente();
            InfoGarantia = new InfoGarantia();
        }

    }
}
