namespace OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CProducto> misProductos = new List<CProducto> { 
                 new CProducto("Papas", 1, 15000),
                 new CProducto("Anlagesico", 2, 35000),
                 new CProducto("Tomate", 1, 30000),
                 new CProducto("Mazana", 1, 25000),
                 new CProducto("Antibiotico", 2, 89000),
                 new CProducto("Antiacido", 2, 43000)
            };

            CTienda miTienda = new CTienda(misProductos);
            miTienda.CalcularInventario();
        }
    }
}