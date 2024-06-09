using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PiezaMecanica : Repuesto
    {

        public string IdPiezaMecanica {  get; set; }

        public string Durabilidad {  get; set; }
        public string Material {  get; set; }
        public string Dimensiones { get; set; }

        public PiezaMecanica() { }

    }
}
