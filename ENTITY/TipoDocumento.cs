using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TipoDocumento : IBaseEntity
    {
        //public string id_documento {  get; set; }
        //public string descripcion {  get; set; }
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento() { }
        public TipoDocumento(string id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}
