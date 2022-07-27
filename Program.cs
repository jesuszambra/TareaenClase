using System;
namespace AutosApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application(new ConcretHyundai());
            app.crearRepusto();
            app.Presupuesto();

            
            
            
        }
    }
}

