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
            //List <int> mesFacturado = new List<int>() {20,50,78,50,11,30,50,11,87,55,66,54};
            //List<int> trismestreFacturado = new List<int>();
            //int sumaFactura = 0;

            //for (int i = 0; i < mesFacturado.Count; i++)
            //{
            //    sumaFactura += mesFacturado[i];

            //    if (mesFacturado[i] == mesFacturado[2] || mesFacturado[i] == mesFacturado[5] || mesFacturado[i] == mesFacturado[8] || mesFacturado[i] == mesFacturado[11])
            //    {
            //        trismestreFacturado.Add(sumaFactura);
            //        sumaFactura = 0;
            //    }
            //}

            //for (int i = 0; i < trismestreFacturado.Count; i++)
            //{
            //    Console.WriteLine($"Trimestre: {i+1}\nFacturacion: ${trismestreFacturado[i]}");
            //}

            int[] facturacion = { 20, 30, 50, 40, 90, 80, 15, 65, 25, 100, 120, 45 };

            int suma = 0;
  
            List<int> trimestre = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                if (i % 3 == 0)
                {
                    suma += facturacion[i-1];
                    trimestre.Add(suma);
                    suma = 0;
                }
                else
                {
                    suma += facturacion[i-1];
                }
            }
            for (int i = 0; i < trimestre.Count; i++)
            {
                Console.WriteLine(trimestre[i]);
            }


            Console.ReadKey();
        }
    }
}
