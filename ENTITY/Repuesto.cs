using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Repuesto
    {
        private string idRepuesto {  get; set; }
        private string Detalles { get; set; }
        private int Precio { get; set; }
        private int Stocks { get; set; }
        private string NoFactura { get; set; }
        private Automovil automovil { get; set; }
        private Categoria categoria { get; set; }

        public Repuesto()
        {
            categoria = new Categoria();
            automovil = new Automovil();
        }
    }
}
