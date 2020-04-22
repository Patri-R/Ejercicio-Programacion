using System;
public class BusquedaTamano
{
    public void BuscarTamano()
    {
        int aciertos = 0;

        public void BuscarPorTamano()
        {
            program program = new program();

            Console.WriteLine("Bienvenido a la busqueda del tamayo, introduzca por favor a partir de que tamanyo quieres buscar (en kb)");
            Console.WriteLine();
            short busqueda = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < program.NumeroDeFicheros; i++)
            {
                if (program.canciones[i].tamanyo >= busqueda)
                {
                    aciertos++;
                    Console.WriteLine();
                    Console.WriteLine("Titulo {0}:");
                    Console.WriteLine("Autor {1}:");
                    Console.WriteLine("Duracion {2}:");
                    Console.WriteLine("Tamanyo {3}:");                  
                }
            }
        }
    }
}