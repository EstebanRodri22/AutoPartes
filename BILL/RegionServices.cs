using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BILL
{
    public class RegionServices
    {
        public List<Region> regiones;
        private RegionRepository regionRepository;
        public RegionServices()
        {
            regionRepository = new RegionRepository();
            regiones = regionRepository.GetAll();
        }

        public List<Region> ConsultarRegiones()
        {
            return regiones;
        }
    }
}
