using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Suzuki
{
    public class SuPastilla : Pastillas
    {
        string texto;
        double precio = 66.00;

        public SuPastilla(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("Su precio es" + precio);
            return texto;
        }
    }
}
