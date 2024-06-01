using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BILL
{
        public class PruebasServices
        {
            private PruebasRepository pruebasRepository;

            public PruebasServices()
            {
                pruebasRepository = new PruebasRepository();
            }

            public DataTable getVentas(string procedureName)
            {
                return pruebasRepository.getVentas(procedureName);
            }
        }
    }

