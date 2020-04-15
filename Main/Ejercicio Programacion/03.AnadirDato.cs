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
            program.Canciones[program.CantidadFicheros].titulo = Console.ReadLine();
            Console.WriteLine("-Artista:");
            program.Canciones[program.CantidadFicheros].artista = Console.ReadLine();
            Console.WriteLine("-Duración:");
            program.Canciones[program.CantidadFicheros].duracion = Console.ReadLine();
            Console.WriteLine("-Tamaño (Kb):");
            program.Canciones[program.CantidadFicheros].tamañoKB = Console.ReadLine();

        }

    }
}
