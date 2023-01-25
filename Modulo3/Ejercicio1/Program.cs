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
            int opcion;
            const int DINERO_INICIAL = 1000;
            double dineroFinal = DINERO_INICIAL;
            bool bandera = false;
            string[] MESES = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Noviembre", "Diciembre"};
            int contador = 0;
            int contadorMeses = 0;



            

            do
            {
                Console.WriteLine($"Desea Invertir Mes {MESES[contador]}: \n 1) SI\n 2) NO");
                Console.Write("Ingrese una opcion (1/2): ");
                opcion = int.Parse(Console.ReadLine());
                bandera = opcion == 1 ? true : false;

                if (bandera)
                {
                    dineroFinal *= 1.02;
                    contador++;
                    contadorMeses++;
                    contador = contador == 11 ? contador = 0:contador;
                    Console.Clear();
                }
                else
                {
                    if (opcion == 2)
                    {
                        
                    }
                    else
                    {
                        
                        Console.WriteLine("El valor ingresado no es valido");
                        Console.Clear();
                    }
                }
            } while (bandera);

            Console.WriteLine($"\nEl dinero que ingreso es de: ${DINERO_INICIAL}\n\nCantidad de meses: {contadorMeses}\n\nEl dinero final con los intereses es de: ${dineroFinal}\n\n");



            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();  
        }
    }
}
