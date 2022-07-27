using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp
{
    public interface IFactory
    {
        public Embrague createEmbrague(string texto, double precio);
        public Pastillas createPastillas(string texto, double precio);
        public Banda createBanda(string texto, double precio);
        
    }
}
