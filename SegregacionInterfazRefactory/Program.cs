namespace SegregacionInterfazRefactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMultiAvanzada avanzado = new CMultiAvanzada();
            avanzado.Escanear();
            avanzado.fax();
            avanzado.Imprimir();
            avanzado.telefono();

            Console.WriteLine("--------------");

            CFax cFax = new CFax();
            cFax.telefono();
            cFax.fax();

            Console.WriteLine("--------------");

            CMultiSencillo sencillo = new CMultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();

            Console.WriteLine("--------------");
            Console.ReadLine();

        }
    }
}