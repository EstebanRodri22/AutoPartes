using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BILL
{
    public class AutomovilServices
    {
        VehiculoRepository VehiculoRepository;

        public AutomovilServices()
        {
            VehiculoRepository = new VehiculoRepository();
        }

        public string insertarAutomovil(Automovil automovil)
        {
            return VehiculoRepository.insertarAutomovil(automovil);
        }
    }
}
