using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BILL
{
    public class MarcaServices
    {
        public List<Marca> marcas;
        private MarcaRepository marcaRepository;
        public MarcaServices()
        {
            marcaRepository = new MarcaRepository();
            marcas = marcaRepository.GetAll();
        }
        public List<Marca> ConsultarMarcas()
        {
            return marcas;
        }
    }
}
