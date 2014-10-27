using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPersonas;


namespace HolaMundoCS
{
    class UsandoClases
    {
        private static void Main(string[] args)
        {
            var p = new Persona();
            //accedemos al SET
            p.Nombre = "Luis";
            p.Edad = 22;
            
            //accedemos al GET
            Console.WriteLine(p.Nombre);
            var p2 = new Persona()
            {
                Nombre = "Juan",
                Edad = 32
            };

            p2.Detalles();
            Console.ReadLine();
        }
    }
}
