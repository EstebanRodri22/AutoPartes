using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public string identificacion {  get; set; }

        public string primerNombre { get; set; }

        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public string telefono { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        public Persona()
        {

        }

        public Persona(string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, TipoDocumento tipoDocumento)
        {
            this.identificacion = identificacion;
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono = telefono;
            TipoDocumento = tipoDocumento;
        }

        public Persona(string identificacion, string primerNombre, string primerApellido, string telefono , TipoDocumento TipoDocumento )
        {
            this.identificacion = identificacion;
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.telefono = telefono;
            this.TipoDocumento = TipoDocumento;
        }

        public Persona(string identificacion, string primerNombre, string primerApellido, string telefono)
        {
            this.identificacion = identificacion;
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.telefono = telefono;
        }
    }
}
