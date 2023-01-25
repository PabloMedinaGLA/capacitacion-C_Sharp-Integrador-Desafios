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
            string contra,contraValue;
            int contador = 0;
            
            Console.Write("\nRegistro\n\nIngrese una Contraseña para su usuario:");
            contra = Console.ReadLine();
            Console.Clear();

            

            do
            {
                Console.Write("\nIngreso\n\nIngrese la Contraseña de su usuario:");
                contraValue = Console.ReadLine();
                if (contador <= 3 && contra == contraValue)
                {
                    Console.WriteLine("\n\tBienvenido!!");
                    contador = 4;
                }
                else
                {
                    contador++;
                    if (contador <= 2)
                    {
                        switch (contador)
                        {
                            case 1:
                                Console.WriteLine("\nTiene dos chances!");
                                break;
                            case 2:
                                Console.WriteLine("\nAtencion!! Ultima Oportunidad");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nTres veces Fallidas");
                    }

                    Console.WriteLine("Presione una tecla para volver a intentar...");
                    Console.ReadKey();
                    Console.Clear();

                }
                
            } while (contador <= 2);



            Console.WriteLine("\n\n\nPresione una tecla para finalizar...");
            Console.ReadKey();  
        }
    }
}
