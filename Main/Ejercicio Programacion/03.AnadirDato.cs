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
            canciones[cantidadFicheros].titulo = Console.ReadLine();
            Console.WriteLine("-Artista:");
            canciones[cantidadFicheros].artista = Console.ReadLine();
            Console.WriteLine("-Duración:");
            canciones[cantidadFicheros].duracion = Console.ReadLine();
            Console.WriteLine("-Tamaño (Kb):");
            canciones[cantidadFicheros].tamañoKB = Console.ReadLine();
        }

    }
}
