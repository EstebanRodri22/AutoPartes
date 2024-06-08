using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PiezaMecanica : Repuesto
    {

        private string IdPiezaMecanica {  get; set; }

        private string Durabilidad {  get; set; }
        private string Material {  get; set; } 
        private string Dimensiones { get; set; }

        public PiezaMecanica() { }

    }
}
