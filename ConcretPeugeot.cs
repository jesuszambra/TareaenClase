using AutosApp.Peugeot;
using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp
{
    public class ConcretPeugeot
    {
        public Banda createBanda(string texto, double precio)
        {
            return new PeuBanda(precio, texto);
        }

        public Embrague createEmbrague(string texto, double precio)
        {
            return new PeuEmbrague(precio, texto);
        }

        public Pastillas createPastillas(string texto, double precio)
        {
            return new PeuPastilla(precio, texto);
        }
    }
}
