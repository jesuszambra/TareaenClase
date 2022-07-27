using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Peugeot
{
    public class PeuBanda : Banda
    {
        string texto;
        double precio = 70.00;

        public PeuBanda(string texto, double precio)
        {
           this.texto = texto;
            this.precio = precio;
        }

        public PeuBanda(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
           Console.WriteLine("El precio de la Banda es: " + precio);
            return texto;
        }



    }
}
