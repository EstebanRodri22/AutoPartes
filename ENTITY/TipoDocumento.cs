using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TipoDocumento
    {
        public string id_documento {  get; set; }
        public string descripcion {  get; set; }

        public TipoDocumento() { }
        public TipoDocumento(string id_documento, string descripcion)
        {
            this.id_documento = id_documento;
            this.descripcion = descripcion;
        }
    }
}
