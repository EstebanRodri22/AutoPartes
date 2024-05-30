using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PiezaMecanica : Repuesto
    {
        public PiezaMecanica(string idRepuesto, string detalles, int precio, int stocks, Automovil automovil, Categoria categoria) : base(idRepuesto, detalles, precio, stocks, automovil, categoria)
        {
        }

        private string IdPiezaMecanica {  get; set; }

        private string Durabilidad {  get; set; }
        private string Material {  get; set; } 
        private string Dimensiones { get; set; }

    }
}
