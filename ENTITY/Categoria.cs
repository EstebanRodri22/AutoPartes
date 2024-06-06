using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categoria
    {
        public string IdCategoria {  get; set; }

        public string NameCategoria { get; set; }

        public Categoria() { }

        public Categoria(string idCategoria, string nameCategoria)
        {
            IdCategoria = idCategoria;
            NameCategoria = nameCategoria;
        }
    }
}
