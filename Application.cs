using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp
{
    public class Application
    {
        IFactory sistema;
        List<IObject> listaOBJ;

        public Application(IFactory sistema)
        {
            this.sistema = sistema;
            listaOBJ = new List<IObject>();
        }

        public void crearRepusto()
        {
           
            Banda banda = sistema.createBanda("---------------------: ", 30.00);
            Embrague embrague = sistema.createEmbrague("-------------------: ", 120.00);
            Pastillas pastillas = sistema.createPastillas("-------------------- ", 30.95);


           

            //Lista de repuestos
            listaOBJ.Add(banda);
            listaOBJ.Add(embrague);
            listaOBJ.Add(pastillas);
        }

        public void Presupuesto()
        {
            string screen = "";
            foreach (var objeto in listaOBJ)
            {
                screen += objeto.Presupuesto() + "\n";

            }
            Console.WriteLine(screen);
        }

    }
}
