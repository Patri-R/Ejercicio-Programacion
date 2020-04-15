using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Programacion
{
    public class busquedaparcial
    {
        public void busqueda()
        {
            Program program = new Program();
            
            string choose;
            
            Console.WriteLine("Has seleccionado búsqueda parcial, dime en que quieres hacer la búsqueda: titulo, autor, duracion, tamaño.");
            choose = Console.ReadLine();
            switch (choose.ToLower)
            {
                case titulo:
                    int aciertos = 0;
                    Console.Write("Introduce lo que quieres buscar por favor: ");
                    string buscar = Console.ReadLine();
                    for (int i = 0; i < program.CantidadFicheros; i++)
                    {
                        if (program.Canciones[i].titulo.Contains(buscar) == true)
                        {
                            aciertos++;
                            Console.WriteLine("Coincidencia {0}:",aciertos);
                            Console.WriteLine("Título: {0}",program.Canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", program.Canciones[i].autor);
                            Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                            Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamañoKB);
                        }
                    }
                    break;
                case título:
                    goto titulo;
                case autor:
                    int aciertos = 0;
                    Console.Write("Introduce lo que quieres buscar por favor: ");
                    string buscar = Console.ReadLine();
                    for (int i = 0; i < program.CantidadFicheros; i++)
                    {
                        if (program.Canciones[i].autor.Contains(buscar) == true)
                        {
                            aciertos++;
                            Console.WriteLine("Coincidencia {0}:", aciertos);
                            Console.WriteLine("Título: {0}", program.Canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", program.Canciones[i].autor);
                            Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                            Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamañoKB);
                        }
                    }
                    break;
                case duracion:
                    int aciertos = 0;
                    Console.Write("Introduce la duración a partir de la cual quieres buscar (en segundos por favor) : ");
                    short buscar = Console.ReadLine();
                    for (int i = 0; i < program.CantidadFicheros; i++)
                    {
                        if (program.Canciones[i].duracion >= buscar)
                        {
                            aciertos++;
                            Console.WriteLine("Coincidencia {0}:", aciertos);
                            Console.WriteLine("Título: {0}", program.Canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", program.Canciones[i].autor);
                            Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                            Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamañoKB);
                        }
                    }
                    break;
                case tamaño:
                    int aciertos = 0;
                    Console.Write("Introduce el tamaño a partir del cual quieres buscar (en Kb por favor) : ");
                    short buscar = Console.ReadLine();
                    for (int i = 0; i < program.CantidadFicheros; i++)
                    {
                        if (program.Canciones[i].tamañoKB >= buscar)
                        {
                            aciertos++;
                            Console.WriteLine("Coincidencia {0}:", aciertos);
                            Console.WriteLine("Título: {0}", program.Canciones[i].titulo);
                            Console.WriteLine("Autor: {0}", program.Canciones[i].autor);
                            Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                            Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamañoKB);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Esa no es ninguna de la opciones, vuelve a pulsar la opción busqueda.");
            }
        }



    }
}
