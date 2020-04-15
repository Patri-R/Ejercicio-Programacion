using System;
public class BusquedaTamano
{
    public void BuscarTamano()
    {
        Program program = new Program();
        int aciertos = 0;
        Console.Write("Introduce el tamaño a partir del cual quieres buscar (en Kb por favor) : ");
        short buscar = Convert.ToInt16( Console.ReadLine());
        for (int i = 0; i < program.CantidadFicheros; i++)
        {
            if (program.Canciones[i].tamanoKB >= buscar)
            {
                aciertos++;
                Console.WriteLine("Coincidencia {0}:", aciertos);
                Console.WriteLine("Título: {0}", program.Canciones[i].titulo);
                Console.WriteLine("Autor: {0}", program.Canciones[i].titulo);
                Console.WriteLine("Duración: {0}", program.Canciones[i].duracion);
                Console.WriteLine("TamañoKB: {0}\n", program.Canciones[i].tamanoKB);
            }
        }
    }
}