using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class InventarioServices
    {
        InventarioRepository repository;
        public InventarioServices() { repository = new InventarioRepository(); }

        public string registrarInventario(InventarioAutomovil inventario, string procedureName)
        {
            try
            {
                return repository.registrarInventario(inventario, procedureName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }
    }
}
