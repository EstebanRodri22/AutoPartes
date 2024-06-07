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
        VehiculoRepository vehiculoRepository;

        public AutomovilServices()
        {
            vehiculoRepository = new VehiculoRepository();
        }
        public List<Automovil> GetAutomovils()
        {
            return vehiculoRepository.GetAutomovils();
        }

        public string insertarAutomovil(Automovil automovil)
        {
            return vehiculoRepository.insertarAutomovil(automovil);
        }
    }
}
