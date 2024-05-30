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

            BILL.MarcaServices marcaServices = new BILL.MarcaServices();
            var lista = marcaServices.ConsultarMarcas();
            foreach ( var item in lista )
            {
                Console.WriteLine(item.name_marca);
            }
            Console.ReadKey();
        }
    }
}
