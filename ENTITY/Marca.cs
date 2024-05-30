using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Marca
    {
        private string IdMarca {  get; set; }

        private string name_marca { get; set; }

        public Marca(string idMarca, string name_marca)
        {
            IdMarca = idMarca;
            this.name_marca = name_marca;
        }
    }
}
