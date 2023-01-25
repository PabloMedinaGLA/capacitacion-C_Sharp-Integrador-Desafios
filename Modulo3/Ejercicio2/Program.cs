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
           
            const int DINERO_INICIAL = 1000;
            double interesMensual = 1.03;
            double dineroFinal = DINERO_INICIAL;
            bool bandera = true;
            string[] MESES = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "octubre", "Noviembre", "Diciembre"};
            int contador = 0;
            int contadorMeses = 0;


            while (bandera)
            {
                if (dineroFinal <= 3000)
                {
                    dineroFinal *= interesMensual;
                    Console.WriteLine($"\nMes: {MESES[contador]}\nDinero hasta ahora: ${dineroFinal}");
                    contador++;
                    contadorMeses++;
                    contador = contador == 12 ? contador = 0 : contador;
                }
                else
                {
                bandera = false;
                }
            }
            Console.WriteLine($"\n\nDineroInicial: ${DINERO_INICIAL}\n\nCantidad de meses: {contadorMeses}\n\nDinero Total con intereses: ${dineroFinal}");

            Console.WriteLine("\n\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
