using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EstadoGarantia
    {
        private string IdEstadoGarantia {  get; set; }
        private string Estado {  get; set; }

        public EstadoGarantia(string idEstadoGarantia, string estado)
        {
            IdEstadoGarantia = idEstadoGarantia;
            Estado = estado;
        }
    }
}
