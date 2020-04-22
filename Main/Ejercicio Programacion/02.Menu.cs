using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Programacion
{
    class Menu
    {
        int opcion = 0;

        public void Menu()
        {
            Console.WriteLine("Hola, bienvenido al menu del programa");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Hola de nuevo si quieres acceder a diferentes lugares del menu tendras");
                Console.WriteLine("Pulsa 1 si quieres añadir un dato al programa");
                Console.WriteLine("Pulsa 2 si quieres mostrar todos los datos");
                Console.WriteLine("Pulse 3 si quieres buscar archivos por su tamanyo");
                Console.WriteLine("Pulse 4 si quieres buscar archivos por su letra");
                Console.WriteLine();
                Console.WriteLine("Introduzca el numero que corresponda a lo que desea");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)

                {
                    case 1:
                        {
                            Console.WriteLine("Bienvenido al caso 1, aqui se añadirán datos al programa");
                            Console.WriteLine();
                            AnadirDato();
                        }

                    case 2:
                        {
                            Console.WriteLine("Bienvenido al caso 2 aqui te mostraremos todos los datos del programa");
                            Console.WriteLine();
                            MostrarDatos();
                        }

                    case 3:
                        {
                            Console.WriteLine("Bienvenido al caso 3, aqui se buscaran los archivos por su tamaño");
                            Console.WriteLine();
                            BuscarPorTamano();
                        }

                    case 4:
                        {
                            Console.WriteLine("Bienvenido al caso 4, aqui se buscaran archivos por su letra");
                            Console.WriteLine();
                            BusquedaPorLetra();
                        }
                }

            } while ((opcion > 4) || (opcion < 1));

            Console.ReadLine();

        }
    }
}
