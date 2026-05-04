using System;

namespace Dsw2026Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 1
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Hamburguesa", 1500));

            //Problema 2
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(1001, "Hamburguesa", 2, 1500));

            //Problema 3
            var prod = new Product();
            prod.SetDescription("Original");

            var p3 = new Problema3();
            Console.WriteLine(p3.CompararCopias(5, prod));

            //Problema 4
            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(10, null, 6));

            //Problema 5
            var p5 = new Problema5();

            Sale s1 = new RetailSale(1000);
            Sale s2 = new WholesaleSale(1000);

            Console.WriteLine(p5.ObtenerImporteFinal(s1));
            Console.WriteLine(p5.ObtenerImporteFinal(s2));

            //Problema 6
            var p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
        }
    }
}
