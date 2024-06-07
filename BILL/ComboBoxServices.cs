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
        private readonly CombosBoxRepository combosBoxRepository;
        
        public ComboBoxServices()
        {
            combosBoxRepository = new CombosBoxRepository();
        }

        public List<TipoDocumento> GetTipoDocumentos()
        {
            return combosBoxRepository.GetEntities<TipoDocumento>("Tipo_documento");
        }

        public List<Marca> GetMarcas()
        {
            return combosBoxRepository.GetEntities<Marca>("Marcas");
        }

        public List<Categoria> GetCategorias()
        {
            return combosBoxRepository.GetEntities<Categoria>("Categorias");
        }

    }
}
