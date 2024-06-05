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
    public class TipoDocServices
    {
        TipoDocRepository tipoDocRepository;
        
        public TipoDocServices()
        {
            tipoDocRepository = new TipoDocRepository();
        }

        public List<TipoDocumento> GetTipoDocumentos()
        {
            return tipoDocRepository.GetTiposDocumento();
        }
    }
}
