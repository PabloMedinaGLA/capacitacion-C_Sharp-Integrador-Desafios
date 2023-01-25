using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, edad, apellido, correo, verificar;
            int opcionCarrera,opcionCurso, respuesta;
            bool cursoRepetido = false;


            List<string> datoPersona = new List<string>();
            List<string> listaCarreras = new List<string>() { "Programacion.NET","Programacion JAVA", "Programacion PHP"};
            List<string> listaCursos = new List<string>() { "HTML: Fundamentos Web", "C# para no Programadores" , "Introduccion a Bases de Datos y SQL", "JavaScript desde Cero" , "Introduccion al Paradigma de Objetos" };
            List<string> cursoInscripto = new List<string>();


            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("\nIngrese apellido: ");
            apellido = Console.ReadLine();

            Console.Write("\nIngrese edad: ");
            edad = Console.ReadLine();

            Console.Write("\nIngrese Correo Electronico: ");
            correo = Console.ReadLine();

            datoPersona.Add(nombre);
            datoPersona.Add(apellido);
            datoPersona.Add(edad);
            datoPersona.Add(correo);
            
            Console.Clear();

            Console.WriteLine("<<<<  Datos Del Alumno  >>>>");
            Console.WriteLine($"Nombre: {datoPersona[0]}");
            Console.WriteLine($"apellido: {datoPersona[1]}");
            Console.WriteLine($"edad: {datoPersona[2]}");
            Console.WriteLine($"correo: {datoPersona[3]}");

            Console.Write("\nLos datos son correctos? \n1) SI\n2) NO\nIngrese la opcion: ");
            verificar = Console.ReadLine();
            Console.Clear();
            
            if(verificar == "1")
            {
                Console.WriteLine("Lista de Carreras Disponibles: \n");
                for (int i = 1; i <= listaCarreras.Count; i++)
                {
                    Console.WriteLine($"{i}. {listaCarreras[i-1]}");
                }
                Console.Write("Ingrese a la Carrera que decia inscribirse(indice): ");
                opcionCarrera = int.Parse( Console.ReadLine() );

                if (opcionCarrera <= listaCarreras.Count)
                {
                    Console.WriteLine("\n<<<Constancia de Inscripcion>>>");
                    Console.WriteLine($"Alumno: {datoPersona[0]} {datoPersona[1]}");
                    Console.WriteLine($"correo: {datoPersona[3]}");
                    Console.WriteLine($"Carrera: {listaCarreras[opcionCarrera-1]}");

                    

                    do
                    {
                        Console.Write("\nDesea Inscribirse a curso: \n1) SI\n2) NO\nIngrese la opcion: ");
                        respuesta = int.Parse( Console.ReadLine() );
                        if (respuesta == 1)
                        {
                            Console.WriteLine("\nLista de Cursos Disponibles: \n");
                            for (int i = 1; i <= listaCursos.Count; i++)
                            {
                                Console.WriteLine($"{i}. {listaCursos[i - 1]}");
                            }
                            Console.Write("\nIngrese al Curso que decia inscribirse(indice): ");
                            opcionCurso = int.Parse(Console.ReadLine());

                            if (cursoInscripto.Count == 0)
                            {
                                cursoInscripto.Add(listaCursos[opcionCurso-1]);
                                Console.WriteLine("\tInscripcion Exitosa");
                            }
                            else
                            {
                                for (int i = 0; i < listaCursos.Count; i++)
                                {
                                    for (int x = 0; x < cursoInscripto.Count; x++)
                                    {
                                        if (cursoInscripto[x] == listaCursos[opcionCurso-1])
                                        {
                                            cursoRepetido = true;
                                        }
                                    }
                                }
                                if (cursoRepetido == true)
                                {
                                    Console.WriteLine("No puede inscribirse al mismo curso");
                                }
                                else
                                {
                                    cursoInscripto.Add(listaCursos[opcionCurso-1]);
                                    Console.WriteLine("\n\tInscripcion Exitosa");
                                    
                                }

                            }
                        }

                    } while (respuesta == 1 && cursoInscripto.Count <= listaCursos.Count);

                    Console.Clear();
                    Console.WriteLine("\n<<<Constancia de Inscripcion>>>");
                    Console.WriteLine($"Alumno: {datoPersona[0]} {datoPersona[1]}");
                    Console.WriteLine($"correo: {datoPersona[3]}");
                    Console.WriteLine($"Carrera: {listaCarreras[opcionCarrera - 1]}");
                    Console.WriteLine("Cursos: ");
                    for (int i = 1; i <= cursoInscripto.Count; i++)
                    {
                        Console.WriteLine($"{i}. {cursoInscripto[i-1]}");
                    }

                }
                else
                {
                    Console.WriteLine("Datos Incorrectos. Ejecutar nuevamente la aplicacion...");
                }
               
            }
            else
            {
                Console.WriteLine("Datos Ingresado Incorrectamente. Ejecutar nuevamente la aplicacion...");
            }
            
            Console.ReadKey(); 

        }
    }
}
