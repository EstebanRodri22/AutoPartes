using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class InfoGarantia
    {

        public string IdGarantia {  get; set; }
        
        public  DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public string detalles {  get; set; }

        public EstadoGarantia EstadoGarantia { get; set; }

        public InfoGarantia() { }

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
