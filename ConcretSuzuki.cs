using AutosApp.Repuestos;
using AutosApp.Suzuki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp
{
    public class ConcretSuzuki
    {
        public Banda createBanda(string texto, double precio)
        {
            return new SuBanda(precio, texto);
        }

        public Embrague createEmbrague(string texto, double precio)
        {
            return new SuEmbrague(precio, texto);
        }

        public Pastillas createPastillas(string texto, double precio)
        {
            return new SuPastilla(precio, texto);
        }
    }
}
