using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_copia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //registro
            Console.Write("Ingrese clave REGISTRO: ");
            string claveRegistro = Console.ReadLine();

            //ingreso
            Console.Write("\nIngrese clave INGRESO: ");
            string claveingreso = Console.ReadLine();




            //for (int i = 0; i <= 2; i++)
            //{
            //    if (claveingreso == claveRegistro)
            //    {
            //        Console.Write("Bienvenido!!");
            //        i = 4;
            //    }
            //    else if (i == 0) 
            //    {
            //        Console.WriteLine("Te queda dos Chance");
            //        Console.WriteLine("\nIngrese clave INGRESO: ");
            //        claveingreso = Console.ReadLine();
            //    }
            //    else if (i == 1) 
            //    {
            //        Console.WriteLine("Ultima Oportunidad");
            //        Console.Write("\nIngrese clave INGRESO: ");
            //        claveingreso = Console.ReadLine();
            //    }
            //    else if (i == 2) 
            //    {
            //        Console.WriteLine("Tres intentos fallidos");
            //    }


            //}

            //Console.WriteLine("Presione una tecla para finalizar...");
            //Console.ReadKey();  


            for (int i = 1; i <= 3; i++)
            {
                if (claveingreso != claveRegistro)
                {
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Te queda dos Chance");
                            Console.Write("\nIngrese clave INGRESO: ");
                            claveingreso = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Ultima Oportunidad");
                            Console.Write("\nIngrese clave INGRESO: ");
                            claveingreso = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Tres intentos fallidos");
                            break;
                    }
                }
                else
                {
                    Console.Write("Bienvenido!!");
                    i = 4;
                }

                Console.WriteLine("Presione una tecla para finalizar...");
                Console.ReadKey();

            }
        }
    }
}
