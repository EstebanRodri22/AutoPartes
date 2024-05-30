using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        private string identificacion {  get; set; }

        private string primerNombre { get; set; }

        private string segundoNombre { get; set; }

        private string primerApellido { get; set; }

        private string segundoApellido { get; set; }
        
        private string telefono { get; set; }

        private TipoDocumento TipoDocumento { get; set; }

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


    }
}
