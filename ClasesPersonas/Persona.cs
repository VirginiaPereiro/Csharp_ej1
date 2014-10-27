using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesPersonas
{
    public abstract class Persona
        //la marcamos como abstracta, por lo que heredarán de esta clase las otras clases que queramos
        //las clases se crean por defecto como privadas, por lo que hay que poner public
        //tiene que ser pública sino es no usable
        //almacena el estado de la clase
        //las propìedades se pueden cambiar con los métodos de getter y setter
    
    {
        //propiedad más especial, porque no nos interesa el que sale por defecto
        //queremos los años en días
        private int _edad;//atributo de instancia

        protected int _2edad;

        public static int AnyoActual = 2014;//todas las personas comparten esta propiedad, ya que la hemos declarado como static

        public static void IncrementarAnyoActual(int n)//desde un método estático sólo se puede acceder a las propiedades estáticas
        //this es el objeto en el que estoy operando, entonces this es el antiestaico
            //this es dinámico, y estático es lo contrario static
        {
            AnyoActual += n;
        }

        public int Edad//propiedad
        {
            get { return _edad; }
            set { _edad = value*365; }
        }
        public int Edad2//propiedad
        {
            get { return _2edad; }
            set { _2edad = value * 365; }
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

        //sobrecargamos el método de Detalles y le ponemos dos parámetros opcionales a unaLinea y a anios
        public void Detalles(int extra, bool unaLinea = true, bool anios = false)
        {
            if (anios)
            {
                if (unaLinea)
                {
                    Console.WriteLine("Nombre: {0} Edad:{1}", Nombre, Edad);
                }
                else
                {
                    Console.WriteLine("Nombre: {0} ", Nombre);
                    Console.WriteLine("Edad: {0}", Edad/365);
                }
            }
            else
            {
                if (unaLinea)
                {
                    Console.WriteLine("Nombre: {0} Edad: {1} ", Nombre, Edad+extra);
                }
                else
                {
                    Console.WriteLine("Nombre: {0} ", Nombre);
                    Console.WriteLine("Edad: {0} ", Edad+extra);
                }
            }
            
        }
    }
}
