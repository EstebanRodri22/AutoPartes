using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BILL.RegionServices regionServices = new BILL.RegionServices();
            //var lista = regionServices.ConsultarRegiones();
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item.Region_Name);
            //}
            BILL.PruebasServices pruebasServices = new BILL.PruebasServices();
           // BILL.MarcaServices marcaServices = new BILL.MarcaServices();
            //var lista = marcaServices.ConsultarMarcas();

            var datatable = pruebasServices.getVentas("get_ventas");
            foreach ( var item in datatable.Rows)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
