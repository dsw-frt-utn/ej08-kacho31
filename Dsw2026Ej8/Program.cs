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
        }
    }
}
