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
        public string Modelo { get; set; }
        public string VIN { get; set; }
        public string IdRegistro { get; set; }
        public string NoFactura { get; set; }
        public byte[] TargetaPropiedad { get; set; }
        public Marca Marca { get; set; }

        public Automovil() { }

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
