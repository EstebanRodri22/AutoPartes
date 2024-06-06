using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BILL
{
    public class ComboBoxServices
    {
        CombosBoxRepository combosBoxRepository;
        
        public ComboBoxServices()
        {
            combosBoxRepository = new CombosBoxRepository();
        }

        public List<TipoDocumento> GetTipoDocumentos()
        {
            return combosBoxRepository.GetTiposDocumento();
        }

        public List<Marca> GetMarcas()
        {
            return combosBoxRepository.GetMarcaList();
        }
    }
}
