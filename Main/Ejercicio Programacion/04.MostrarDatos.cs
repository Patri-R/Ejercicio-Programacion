//Patri
using System;
public class Mostrar
{
    public void MostrarDatos(ushort posicionMinima, ushort posicionMaxima)
    {
        Program program = new Program();
        for(ushort i = posicionMinima; i < posicionMaxima; i++)
        {
            Console.WriteLine("Canción " + i+1 + "\n Título: " + program.Canciones[i].titulo + "\n Artista: " + program.Canciones[i].artista
                + "\n Duración: " + program.Canciones[i].duracion + "\n Tamaño(KB): " + program.Canciones[i].tamanoKB);
        }
    }
}