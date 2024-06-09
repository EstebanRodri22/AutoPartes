using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PiezaElectrica : Repuesto
    {
        public string IdPiezaElectrica { get; set; }
        public string voltaje { get; set; }
        public string resistencia { get; set; }

        public PiezaElectrica()
        {

        }

     
       
    }
}
