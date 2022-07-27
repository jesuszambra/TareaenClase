using AutosApp.Hyundai;
using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp
{
    public class ConcretHyundai : IFactory
    {
        public Banda createBanda(string texto, double precio)
        {
            return new HyuBanda(precio, texto);
        }

        public Embrague createEmbrague(string texto, double precio)
        {
            return new HyuEmbrague(precio, texto);
        }

        public Pastillas createPastillas(string texto, double precio)
        {
            return new HyuPastilla(precio, texto);
        }
    }
}
