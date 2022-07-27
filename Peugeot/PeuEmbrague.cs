using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Peugeot
{
    public class PeuEmbrague : Embrague
    {
        string texto;
        double precio = 140.00;

        public PeuEmbrague(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("El precio del Embreague es: " + precio);
            return texto;
        }
    }
}
