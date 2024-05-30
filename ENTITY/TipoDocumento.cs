using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TipoDocumento
    {
        private string id_documento {  get; set; }
        private string descripcion {  get; set; }

        public TipoDocumento(string id_documento, string descripcion)
        {
            this.id_documento = id_documento;
            this.descripcion = descripcion;
        }
    }
}
