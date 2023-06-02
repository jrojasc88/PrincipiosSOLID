namespace OpenCloseRefactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CBaseInventario> misProductos = new List<CBaseInventario> {
                 new CInventarioAlimento(new CProducto("Papas", 1, 15000)),
                 new CInventarioMedicamento(new CProducto("Anlagesico", 2, 35000)),
                 new CInventarioAlimento(new CProducto("Tomate", 1, 30000)),
                 new CInventarioAlimento(new CProducto("Mazana", 1, 25000)),
                 new CInventarioMedicamento(new CProducto("Antibiotico", 2, 89000)),
                 new CInventarioMedicamento(new CProducto("Antiacido", 2, 43000))
            };

            CTienda miTienda = new CTienda(misProductos);
            miTienda.CalcularInventario();
        }
    }
}