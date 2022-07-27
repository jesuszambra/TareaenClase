using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Hyundai
{
    public class HyuPastilla : Pastillas
    {
        string texto;
        double precio = 30.95;
        public HyuPastilla(string texto, double precio)
        {
            this.texto = texto;
            this.precio = precio;
        }

        public HyuPastilla(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("Precio de las Patillas de freno Hyundai: " + precio);
            return texto;
        }
    }
}
