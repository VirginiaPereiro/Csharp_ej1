using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoCS
{
    class Program
    {
        //var sólo puede estar dentro de funciones, no se podrá a nivel de clase
        //así que las variables se pondrán especificando el tipo de variable
 
        

        static void Mai(string[] args)//le hemos cambiado el nombre porque en un proyecto no puede haber más de un main
        {
            var nombre = "Virginia";//variable String

            var edad = 22;//el directamente lo convierte a int32
            var edad2 = 22L;//le fuerzo a que sea un int64, o sea un long
            var edad3 = 22M;//le fuerza a que sea un decimal

            var fecha = DateTime.Now;
            
            var texto = String.Format("Hola {0} tienes {1} años. Hoy es {2:d}", nombre, edad, fecha);
            //para inyectar valores
            //{2:d} para decir el tipo de dato quieres, estableces formato, en este caso sort date

            //los arrays no son redimensionables, siempre empiezan por el 0, no existe array asociativo ya que serán los diccionarios
            var arr1 = new int[4];
            arr1[0] = 44;
            arr1[1] = 10;
            arr1[2] = 33;
            arr1[3] = 22;

            int[] arr2 = {4, 23, 12, 5};

            //las propiedades clases y métodos en mayúsculas
            //en minúscula van las variables

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("La posición {0} vale {1}",i,arr1[i]);
            }

            foreach (var i in arr2)
            {
                Console.WriteLine("Vale {0}",i);//recupera el valor directamente, el valor de i
                //no es como Java, que recupera sólo el índice 
            }


            Console.WriteLine("Hola mundo soy un programa C#");
            Console.WriteLine(texto);
            Console.ReadLine();//hasta que no le demos al intro no se va

        }
    }
}
