using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Hyundai
{
    public class HyuEmbrague:Embrague
    {
        string texto;
        double precio = 120.00;
        public HyuEmbrague(string texto, double precio)
        {
            this.texto = texto; 
            this.precio = precio;
        }

        public HyuEmbrague(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("Precio del Embrague Hyundai: " + precio);
            return texto;
        }
    }
}
