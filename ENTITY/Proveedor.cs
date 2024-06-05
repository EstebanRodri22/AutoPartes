using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proveedor : Persona
    {
        public byte[] firma { get; set; }

        public Proveedor(string identificacion, string primerNombre, string primerApellido, string telefono) : base(identificacion, primerNombre,  primerApellido, telefono)
        {

        }
        public Proveedor()
        {

        }

        public Proveedor(string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, TipoDocumento tipoDocumento) : base(identificacion, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, tipoDocumento)
        {
        }

        public Proveedor(byte[] firma,string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, TipoDocumento tipoDocumento) : base(identificacion, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, tipoDocumento)
        {
            this.firma = firma;
        }





    }
}
