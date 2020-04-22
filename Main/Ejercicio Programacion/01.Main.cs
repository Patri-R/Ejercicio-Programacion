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
            Menu menu = new Menu();           
            AnyadirDato nuevoDato = new AnyadirDato();
            Mostrar mostrarCompleto = new Mostrar();
            BusquedaTamano busquedaTamano = new BusquedaTamano();
            busquedaparcial busquedaparcial = new busquedaparcial();


            try
            {
                menu.MostrarMenu();
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        nuevoDato.RellenarDatos();
                        break;
                    case 2:
                        mostrarCompleto.MostrarDatos();
                        
                        break;
                    case 3:
                        busquedaTamano.BuscarTamano();
                        break;
                    case 4:
                        busquedaparcial.busqueda();
                        break;
                    case 5:
                        Console.WriteLine("Fin de programa");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande");
            }
            Console.Clear();
        }
        while (opcion != 5);
    }
}