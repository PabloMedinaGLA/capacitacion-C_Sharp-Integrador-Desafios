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
            const double IVA = 1.21;
            double remera = 59.90;
            double pantalon = 99.90;
            double campera = 149.90;

            Console.WriteLine($"La remera sin iva es: ${remera}, y con IVA es: ${remera * IVA}");
            Console.WriteLine($"El pantalon sin iva es: ${pantalon}, y con IVA es: ${pantalon * IVA}");
            Console.WriteLine($"La campera sin iva es: ${campera}, y con IVA es: ${campera * IVA}");



            Console.ReadKey();  
        }
    }
}
