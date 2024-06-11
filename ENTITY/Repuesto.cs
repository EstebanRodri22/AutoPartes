using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Repuesto
    {
        public string idRepuesto {  get; set; }
        public string Detalles { get; set; }
        public int Precio { get; set; }
        public int cantidad { get; set; }
        public string NoFactura { get; set; }
        
        public Automovil automovil { get; set; }
        public Categoria categoria { get; set; }

        public Repuesto()
        {
            categoria = new Categoria();
            automovil = new Automovil();
        }
    }
}
