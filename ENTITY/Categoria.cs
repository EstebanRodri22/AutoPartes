using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categoria
    {
        private string IdCategoria {  get; set; }

        private string NameCategoria { get; set; }

        public Categoria(string idCategoria, string nameCategoria)
        {
            IdCategoria = idCategoria;
            NameCategoria = nameCategoria;
        }
    }
}
