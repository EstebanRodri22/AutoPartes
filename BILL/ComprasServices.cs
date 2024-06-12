using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BILL
{
    public class ComprasServices
    {
        ComprasRepository comprasRepository;
        PruebasRepository pruebasRepository;

        public ComprasServices()
        {
            comprasRepository = new ComprasRepository();
            pruebasRepository = new PruebasRepository();
        }
        
        public string InsertarCompra(Compras compra, string ProcedureName)
        {
            try
            {
                return comprasRepository.InsertarCompra(compra, ProcedureName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message, ex);
            }
        }

    }
}
