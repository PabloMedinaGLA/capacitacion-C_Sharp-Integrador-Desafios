using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2;

            Console.WriteLine("Ingrese primer nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            if (nota1 >= 4 && nota2 >= 4)
            {
                Console.WriteLine("Apruebo los 2 examenes");
            }
            else if (nota1 < 4 && nota2 < 4)
            {
                Console.WriteLine("Tiene que Recuperar los 2 examenes");
            }
            else if (nota1 >= 4 || nota2 < 4)
            {
                Console.WriteLine("Tiene que Recuperar el examen 2");
            }
            else if (nota1 < 4 || nota2 >= 4)
            {
                Console.WriteLine("Tiene que Recuperar el examen 1");
            }
            

            Console.ReadKey();

        }
    }
}
