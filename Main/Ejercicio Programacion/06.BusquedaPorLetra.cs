using System;

public class busquedaparcial
{
    public void busqueda()
    {
        Program program = new Program();
        int aciertos = 0;
        Console.Write("Introduce lo que quieres buscar por favor: ");
        string buscar = Console.ReadLine();

        for (int i = 0; i < program.CantidadFicheros; i++)
        {
            if (program.Canciones[i].titulo.Contains(buscar) == true || program.Canciones[i].artista.Contains(buscar) == true)
            {
                aciertos++;
                Console.WriteLine("Coincidencia {0}:", aciertos);
                Console.WriteLine("Título: {0}", program.Canciones[i].titulo);
                Console.WriteLine("Autor: {0}", program.Canciones[i].artista);
                Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamanoKB);
            }
        }

    }
}


