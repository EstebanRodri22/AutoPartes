using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class InventarioAutomovil
    {
        private string IdRegistro {  get; set; }
        private DateTime FechaIngreso { get; set; }
        private Automovil Automovil { get; set; }
        private EstadoInventario EstadoInventario { get;}

        public InventarioAutomovil(string idRegistro, DateTime fechaIngreso, Automovil automovil, EstadoInventario estadoInventario)
        {
            IdRegistro = idRegistro;
            FechaIngreso = fechaIngreso;
            Automovil = automovil;
            EstadoInventario = estadoInventario;
        }
    }
}
