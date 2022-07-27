using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Suzuki
{
    public class SuEmbrague : Embrague
    {
        string texto;
        double precio = 30.00;

        public SuEmbrague(double precio, string texto)
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
