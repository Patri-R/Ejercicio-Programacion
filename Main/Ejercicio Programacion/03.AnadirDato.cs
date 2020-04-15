using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Programacion
{
    public class AnyadirDato
    {
        
        public void saludo()
        {
            Program program = new Program ();
            cantidadFicheros ++;
            Console.WriteLine("A continuación te mostraré los datos a rellenar" +
                "\n-Título:");
            program.Canciones[CantidadFicheros].titulo = Console.ReadLine();
            Console.WriteLine("-Artista:");
            program.Canciones[CantidadFicheros].artista = Console.ReadLine();
            Console.WriteLine("-Duración:");
            program.Canciones[CantidadFicheros].duracion = Console.ReadLine();
            Console.WriteLine("-Tamaño (Kb):");
            program.Canciones[CantidadFicheros].tamañoKB = Console.ReadLine();
        }

    }
}
