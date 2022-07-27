using AutosApp.Repuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosApp.Hyundai
{
    public class HyuBanda : Banda
    {
        
        string texto;
        double precio = 30.00;

        public HyuBanda(string texto,  double precio )
        {
            this .texto = texto;
            this.precio = precio;
        }

        public HyuBanda(double precio, string texto)
        {
            this.precio = precio;
            this.texto = texto;
        }

        public override string Presupuesto()
        {
            Console.WriteLine("Precio de la Banda de distribución hyundai: "+ precio);
            return texto ;
        }
    }
}
