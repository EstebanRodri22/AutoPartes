﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class PiezaElectrica : Repuesto
    {
        private string IdPiezaElectrica { get; set; }
        private string voltaje { get; set; }
        private string resistencia { get; set; }

        public PiezaElectrica(string idRepuesto, string detalles, int precio, int stocks, Automovil automovil, Categoria categoria) : base(idRepuesto, detalles, precio, stocks, automovil, categoria)
        {
        }

     
       
    }
}
