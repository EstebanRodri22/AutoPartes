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

        public Cliente(string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono) : base(identificacion, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono)
        {
        }


    }
}
