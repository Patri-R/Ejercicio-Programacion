//Patri
using System;
public class Mostrar
{
    public void MostrarDatos()
    {
        Program program = new Program();
        for(int i = 0; i < program.CantidadFicheros; i++)
        {
            Console.WriteLine("Canción {0} ",i+1 + "\n Título: " + program.Canciones[i].titulo + "\n Artista: " + program.Canciones[i].artista
                + "\n Duración: " + program.Canciones[i].duracion + "\n Tamaño(KB): " + program.Canciones[i].tamanoKB);
        }
    }
}