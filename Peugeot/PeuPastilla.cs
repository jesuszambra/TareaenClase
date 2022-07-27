using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Peugeot
{
    public class PeuPastilla :Pastillas
    {
        string texto;
        double precio = 45.00;

        public PeuPastilla(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("El precio de las pastillas es: " + precio);
            return texto;
        }
    }
}
