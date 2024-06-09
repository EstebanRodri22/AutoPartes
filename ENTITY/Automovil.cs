using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Automovil
    {
        public string Placa { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public string VIN { get; set; }
        public string NoFactura {  get; set; }
        public byte[] TargetaPropiedad { get; set; }

        public string Display => $"{Marca.Descripcion} - {Placa}";

        public InventarioAutomovil inventario {  get; set; }


        public Automovil() 
        {
            inventario = new InventarioAutomovil();
            Marca = new Marca();
        }

        

    }
}
