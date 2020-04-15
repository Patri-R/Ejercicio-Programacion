using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Programacion
{
    public class AnyadirDato
    {
        
        public void saludo()
        {
            cantidadFicheros ++;
            Console.WriteLine("A continuación te mostraré los datos a rellenar" +
                "\n-Título:");
            program.canciones[cantidadFicheros].titulo = Console.ReadLine();
            Console.WriteLine("-Artista:");
            program.canciones[cantidadFicheros].artista = Console.ReadLine();
            Console.WriteLine("-Duración:");
            program.canciones[cantidadFicheros].duracion = Console.ReadLine();
            Console.WriteLine("-Tamaño (Kb):");
            program.canciones[cantidadFicheros].tamañoKB = Console.ReadLine();
        }

    }
}
