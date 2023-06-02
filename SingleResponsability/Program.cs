namespace SingleResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Juan", "Desarrollador", 35, 18000);
            Console.WriteLine(empleado);
            Console.ReadLine();
            empleado.PagarImpuesto();
        }
    }
}