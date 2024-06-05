using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BILL
{
    public class ProveedorServices
    {
        ProveedoresRepository ProveedoresRepository;
        public ProveedorServices() 
        {
            ProveedoresRepository = new ProveedoresRepository();
        }

        public string insertarProveedor(Proveedor proveedor, string procedureName)
        {
            try 
            {
                return ProveedoresRepository.insertar2(proveedor, procedureName);
            }
            catch(Exception ex) 
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }
    }
}
