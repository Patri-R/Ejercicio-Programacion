//Patri

public class Program
{
    public struct cancion
    {
        public string titulo;
        public string artista;
        public string duracion;
        public byte tamanoKB;
        
    }
    public int cantidadFicheros = 0;
  

    static byte opcion = 0;
    static int capacidad = 1000;
    static cancion[] canciones = new cancion[capacidad];

    public cancion[] Canciones { get { return canciones; } set { canciones=value;} }



    public static void Main()
    {

    }
}