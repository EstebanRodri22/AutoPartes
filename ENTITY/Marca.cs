using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Marca
    {
        public string IdMarca {  get; set; }

        public string name_marca { get; set; }

        public Marca() { }

        public Marca(string idMarca, string name_marca)
        {
            IdMarca = idMarca;
            this.name_marca = name_marca;
        }

        public override string ToString()
        {
            return name_marca;
        }
    }
}
