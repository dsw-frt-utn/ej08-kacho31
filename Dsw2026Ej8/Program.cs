namespace Dsw2026Ej8
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            //Problema 1
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca Cola", 1.50m);
            Console.WriteLine(etiqueta);

            //Problema 2
            var p2 = new Problema2();
            string resultado = p2.CrearResumenVenta(1001, "Coca Cola", 3, 1.50m);
            Console.WriteLine(resultado);

            string resultado2 = p2.CrearResumenVenta(1001, "Coca Cola", -1, 1.50m);
            Console.WriteLine(resultado2);

            //Problema 3
            var producto = new Product("Descripcion original");
            var p3 = new Problema3();
            string resultado3 = p3.CompararCopias(5, producto);
            Console.WriteLine(resultado3);

            //Problema 4
            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));
            Console.WriteLine(p4.CalcularPromedio(8, null, 10));
            Console.WriteLine(p4.CalcularPromedio(null, null, null));
        }
    }
}
