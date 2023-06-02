namespace SegregacionInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMultiAvanzado avanzado= new CMultiAvanzado();
            avanzado.Escanear();
            avanzado.Fax();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("--------------");

            CFax cFax= new CFax();
            cFax.Telefono();
            cFax.Fax();
            cFax.Imprimir();

            Console.WriteLine("--------------");

            CMultiSencillo sencillo = new CMultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            sencillo.Telefono();

            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }
}