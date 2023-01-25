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
            List <int> vector =  new List<int>() { 1002,104, 309, 500};
            List<int> vectorResult = new List<int>();
            int contador = 0;

            for (int i = vector.Count-1; i >= 0 ;i--)
            {
                vectorResult.Add(vector[i]);
            }

            Console.WriteLine("Vector inicio");
            for (int i = 0; i < vector.Count; i++)
            {
                Console.WriteLine($"{i})\t{vector[i]}");
            }

            Console.WriteLine("\nVector destino");
            for (int i = 0; i < vectorResult.Count; i++)
            {
                Console.WriteLine($"{i})\t{vectorResult[i]}");
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();  
        }
    }
}
