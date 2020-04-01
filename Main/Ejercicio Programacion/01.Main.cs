//Patri
using System;

public class Program
{
    public struct cancion
    {
        public string titulo;
        public string artista;
        public string duracion;
        public byte tamanoKB;
        
    }
    static int cantidadFicheros = 0;
    public int CantidadFicheros { get { return cantidadFicheros; }set { cantidadFicheros = value; } }
  

    static byte opcion = 0;
    static int capacidad = 1000;
    static cancion[] canciones = new cancion[capacidad];

    public cancion[] Canciones { get { return canciones; } set { canciones=value;} }



    public static void Main()
    {
        do
        {
            Mostrar mostrarCompleto = new Mostrar();
            
            try
            {
                //Mostrar menú
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //Añadir dato
                        break;
                    case 2:
                        mostrarCompleto.MostrarDatos(0, Convert.ToUInt16(cantidadFicheros));
                        break;
                    case 3:
                        //buscar por tamaño
                        break;
                    case 4:
                        //buscar por letra
                        break;
                    case 5:
                        Console.WriteLine("Fin de programa");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande");
            }
        }
        while (opcion != 5);
    }
}