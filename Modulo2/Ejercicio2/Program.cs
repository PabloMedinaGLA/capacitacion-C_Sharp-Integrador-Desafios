using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, suma, diferencia, producto, division;
            



            Console.WriteLine("Ingrese Primer Numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo Numero: ");
            n2 = double.Parse(Console.ReadLine());


            if (n1 > n2)
            {
                suma = n1 + n2;
                diferencia = n1 - n2;

                Console.WriteLine($"La suma entre n1 y n2 es igual a {suma}");
                Console.WriteLine($"La diferencia entre n1 y n2 es igual a {diferencia}");

            }
            else 
            {
                producto = n1 * n2;
                division = n1 / n2;

                Console.WriteLine($"el producto entre n1 y n2 es igual a {producto}");
                Console.WriteLine($"La division entre n1 y n2 es igual a {division}");
            }

            Console.ReadKey();
        }
    }
}
