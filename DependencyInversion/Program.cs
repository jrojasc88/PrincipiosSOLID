namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAlmacen miAlmacen = new CAlmacen();
            double total = 0;

            miAlmacen.AdicionarProducto(new CProducto("Tomate", 0, 15000));
            miAlmacen.AdicionarProducto(new CProducto("Banana", 0, 30000));
            miAlmacen.AdicionarProducto(new CProducto("Analgesico", 1, 23000));
            miAlmacen.AdicionarProducto(new CProducto("Jeans", 2, 450000));
            miAlmacen.AdicionarProducto(new CProducto("Antiacido", 1, 68000));
            miAlmacen.AdicionarProducto(new CProducto("Blusa", 2, 15000));

            Console.WriteLine("-----------------------");

            CAuditor miAuditor = new CAuditor(miAlmacen);
            total = miAuditor.totalesAlimentos();

            Console.WriteLine("El total de los alimentos es: ", total);
            Console.ReadLine();
        }
    }
}