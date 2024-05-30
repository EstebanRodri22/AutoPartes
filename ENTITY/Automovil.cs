using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Automovil
    {
        private string Placa { get; set; }
        private string Modelo { get; set; }
        private string VIN { get; set; }
        private string IdRegistro { get; set; }
        private string NoFactura { get; set; }
        private byte[] TargetaPropiedad { get; set; }
        private Marca Marca { get; set; }

        public Automovil(string placa, string modelo, string vIN, string idRegistro, string noFactura, byte[] targetaPropiedad, Marca marca)
        {
            Placa = placa;
            Modelo = modelo;
            VIN = vIN;
            IdRegistro = idRegistro;
            NoFactura = noFactura;
            TargetaPropiedad = targetaPropiedad;
            Marca = marca;
        }

        public Automovil(string placa, string modelo, string vIN, byte[] targetaPropiedad, Marca marca)
        {
            Placa = placa;
            Modelo = modelo;
            VIN = vIN;
            TargetaPropiedad = targetaPropiedad;
            Marca = marca;
        }

        public Automovil(string placa, string modelo, string vIN, string idRegistro, byte[] targetaPropiedad, Marca marca)
        {
            Placa = placa;
            Modelo = modelo;
            VIN = vIN;
            IdRegistro = idRegistro;
            TargetaPropiedad = targetaPropiedad;
            Marca = marca;
        }
    }
}
