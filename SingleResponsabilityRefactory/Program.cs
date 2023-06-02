namespace SingleResponsabilityRefactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Juan", "Desarrollador", 32, 18000);
            Console.WriteLine(empleado);
            Console.ReadLine();

            Console.WriteLine(CHacienda.CalularImpuesto(empleado));
            Console.ReadLine();

            CHacienda.PagarImpuesto(empleado);
        }
    }
}