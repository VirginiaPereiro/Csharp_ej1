using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Alumno : Persona//alumno hereda de persona
    {
        public int Nota { get; set; }

        //public void borrar()
        //{
        //    //_edad = 22;//aunque herede de persona no va a poder acceder a él porque es privado
        //    _2edad = 22;//este que es protected pues si que se puede acceder a él
        //}
    }
}
