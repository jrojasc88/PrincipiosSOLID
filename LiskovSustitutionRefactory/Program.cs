namespace LiskovSustitutionRefactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Principal miNoticiero = new CNoticiero("Hola a todos.");
            miNoticiero.Muestra();

            Principal miRadio = new CRadio("Como estan??");
            miRadio.Muestra();
        }
    }
}