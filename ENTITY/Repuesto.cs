using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Repuesto
    {
        private string idRepuesto {  get; set; }
        private string Detalles { get; set; }
        private int Precio { get; set; }
        private int Stocks { get; set; }
        private string NoFactura { get; set; }
        private Automovil Automovil { get; set; }
        private Categoria Categoria { get; set; }



        public Repuesto(string idRepuesto, string detalles, int precio, int stocks, string noFactura, Automovil automovil, Categoria categoria)
        {
            this.idRepuesto = idRepuesto;
            Detalles = detalles;
            Precio = precio;
            Stocks = stocks;
            NoFactura = noFactura;
            Automovil = automovil;
            Categoria = categoria;
        }

        public Repuesto(string idRepuesto, string detalles, int precio, int stocks, Automovil automovil, Categoria categoria)
        {
            this.idRepuesto = idRepuesto;
            Detalles = detalles;
            Precio = precio;
            Stocks = stocks;
            Automovil = automovil;
            Categoria = categoria;
        }
    }
}
