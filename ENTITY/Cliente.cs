using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente : Persona
    {
        private string correo {  get; set; }

        public Cliente(string correo,string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, TipoDocumento tipoDocumento) : base(identificacion, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, tipoDocumento)
        {
            this.correo = correo;
        }

        public Cliente(string correo, string identificacion, string primerNombre, string primerApellido, string telefono, TipoDocumento TipoDocumento) : base(identificacion, primerNombre, primerApellido, telefono, TipoDocumento)
        {
            this.correo = correo;
        }

    }
}
