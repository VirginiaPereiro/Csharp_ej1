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
            //aquí podemos modificar la propiedad estática, hay que hacerlo desde la clase Persona
            Persona.AnyoActual = 2015;

            var p = new Alumno();
            //accedemos al SET
            p.Nombre = "Luis";
            p.Edad = 12;
            
            //accedemos al GET
            Console.WriteLine(p.Nombre);
            var p2 = new Alumno()
            {
                Nombre = "Juan",
                Edad = 32
            };

            p2.Detalles();
            Persona.IncrementarAnyoActual(8);//llamamos al método estático
            p.Detalles(60,anios:true);
            Operaciones.Sumar(5, 5);//una clase estática con su método estático
            Console.ReadLine();
        }
    }
}
