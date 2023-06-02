namespace LiskovSustitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primera prueba con new
            CNoticiero noticiero = new CNoticiero("Hola a todos.");
            noticiero.Muestra();

            CRadio miRadio = new CRadio("Como estan?");
            miRadio.Muestra();

            Console.WriteLine("---------");
            Console.ReadLine();

            CNoticiero sustitucion = new CRadio("Estamos probando.");
            sustitucion.Muestra();
        }
    }
}