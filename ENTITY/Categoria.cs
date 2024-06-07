using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categoria : IBaseEntity
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria () { }
    }
}
