using System;
public class BusquedaTamano
{
    public void BuscarTamano()
    {
        int aciertos = 0;

        Program program = new Program();

        Console.WriteLine("Bienvenido a la busqueda del tamayo, introduzca por favor a partir de que tamanyo quieres buscar (en kb)");
        Console.WriteLine();
        short busqueda = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < program.CantidadFicheros; i++)
        {
            if (program.Canciones[i].tamanoKB >= busqueda)
            {
                aciertos++;
                Console.WriteLine();
                Console.WriteLine("Titulo {0}:", program.Canciones[i].titulo);
                Console.WriteLine("Autor {1}:", program.Canciones[i].artista);
                Console.WriteLine("Duracion {2}:", program.Canciones[i].duracion);
                Console.WriteLine("Tamanyo {3}:", program.Canciones[i].tamanoKB);
            }
        }
    }
}