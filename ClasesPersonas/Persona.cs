using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesPersonas
{
    public class Persona
        //las clases se crean por defecto como privadas, por lo que hay que poner public
        //tiene que ser pública sino es no usable
        //almacena el estado de la clase
        //las propìedades se pueden cambiar con los métodos de getter y setter
    
    {
        //propiedad más especial, porque no nos interesa el que sale por defecto
        //queremos los años en días
        private int _edad;//atributo

        public int Edad//propiedad
        {
            get { return _edad; }
            set { _edad = value*365; }
        }

        //poniendo prop se crea ya sóla la clase, así creamos las propiedades de la clase
        //public int Edad { get; set; } //si queremos que el get o el set sea privado se pone delante private
        public String Nombre { get; set; }

        //si no defino el constructor se crea el de por defecto, pero si creo uno me cargo el de por defecto
        //guardo en memoria
        public Persona()
        {
        }

        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //creamos un método
        public void Detalles()
        {
            Console.WriteLine("Nombre: {0} Edad: {1}",Nombre,Edad);
        }
    }
}
