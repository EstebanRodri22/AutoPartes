using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EstadoInventario
    {
        public string IdEstadoInventario {  get; set; }
        public int PiezaRecuperadas {  get; set; }
        public string EstadoDesmontaje { get; set; }

       public EstadoInventario() { }


    }
}
