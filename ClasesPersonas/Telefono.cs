using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Telefono
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public double Precio { get; set; }
    
        //método que devuelva el coste del telf + iva precio*1.21
        public double CalculoPrecio()
        {
            var precioFinal = Precio*1.21;
            return precioFinal;
        }
    }
}
