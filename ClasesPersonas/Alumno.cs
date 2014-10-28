using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Alumno : Persona//alumno hereda de persona
        //hereda todas las propiedades de Persona
    {
        public int Nota { get; set; }

        //public void borrar()
        //{
        //    //_edad = 22;//aunque herede de persona no va a poder acceder a él porque es privado
        //    _2edad = 22;//este que es protected pues si que se puede acceder a él
        //}

        //sobrescribir el método de detalles de persona

        //Constructores de los que heredan
        public Alumno()
        {
            
        }

        public Alumno(String nombre, int edad, int nota) 
            :base(nombre,edad)//hereda nombre y edad de persona
        {
            Nota = nota;
        }


        public Alumno(int edad, int nota)
            : base("Alumno sin nombre", edad)//hereda del constructor que tiene nombre y edad de persona, en el nombre también podemos poner null
        {
            Nota = nota;
        }


        sealed public override void Detalles() 
        {
            Console.WriteLine("Nombre: {0} Edad:{1} Nota: {2}", Nombre, Edad, Nota);
        }

        //ToString ya C# lo tiene como Virtual
        public override string ToString()
        {
            return "Pepe";
        }
    }
}
