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
            return ProveedoresRepository.insertar2(proveedor, procedureName);
        }
    }
}
