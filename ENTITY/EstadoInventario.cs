using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class EstadoInventario
    {
        private string IdEstadoInventario {  get; set; }
        private int PiezaRecuperadas {  get; set; }
        private string EstadoDesmontaje { get; set; }

        public EstadoInventario(string idEstadoInventario, int piezaRecuperadas, string estadoDesmontaje)
        {
            IdEstadoInventario = idEstadoInventario;
            PiezaRecuperadas = piezaRecuperadas;
            EstadoDesmontaje = estadoDesmontaje;
        }


    }
}
