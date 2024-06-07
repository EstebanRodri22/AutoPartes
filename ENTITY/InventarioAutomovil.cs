using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class InventarioAutomovil
    {
        public string IdRegistro {  get; set; }
        public DateTime FechaIngreso { get; set; }
        public string placa { get; set; }
        public EstadoInventario estadoInventario { get; set; }

        public InventarioAutomovil() 
        {
            estadoInventario = new EstadoInventario();
        }

        public override string ToString()
        {
            return IdRegistro;
        }
    }
}
