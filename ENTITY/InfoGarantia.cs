using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class InfoGarantia
    {

        private string IdGarantia {  get; set; }
        
        private  DateTime FechaInicio { get; set; }

        private DateTime FechaFin { get; set; }

        private string detalles {  get; set; }

        private EstadoGarantia EstadoGarantia { get; set; }

        public InfoGarantia(string idGarantia, DateTime fechaInicio, DateTime fechaFin, string detalles, EstadoGarantia estadoGarantia)
        {
            IdGarantia = idGarantia;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            this.detalles = detalles;
            EstadoGarantia = estadoGarantia;
        }
    }
}
