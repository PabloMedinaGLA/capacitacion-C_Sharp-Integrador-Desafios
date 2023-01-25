using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del alumno: ");
            int notaAlumno = Convert.ToInt32(Console.ReadLine());

            if(notaAlumno >= 7)
            {
                Console.WriteLine("El alumno PROMOCIONA");
            }
            else if(notaAlumno < 7 && notaAlumno >= 4)
            {
                Console.WriteLine("El alumno APRUEBA, tiene que rendir Final");
            }
            else
            {
                Console.WriteLine("El alumno DESAPRUEBA, tiene que Recursar");
            }


            Console.ReadKey();

        }
    }
}
