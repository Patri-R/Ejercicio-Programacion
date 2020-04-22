using System;

public class AnyadirDato
{

    public void RellenarDatos()
    {
        Program program = new Program();
        if (program.CantidadFicheros < 1000)
        {            
            Console.WriteLine("A continuación te mostraré los datos a rellenar" +
                "\n-Título:");
            program.Canciones[program.CantidadFicheros].titulo = Console.ReadLine();
            Console.WriteLine("-Artista:");
            program.Canciones[program.CantidadFicheros].artista = Console.ReadLine();
            Console.WriteLine("-Duración:");
            program.Canciones[program.CantidadFicheros].duracion = Console.ReadLine();            

            try
            {
                Console.WriteLine("-Tamaño (Kb):");
                program.Canciones[program.CantidadFicheros].tamanoKB = Convert.ToByte(Console.ReadLine());
                program.CantidadFicheros++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Tamaño no válido. Se han borrado los datos de la canción introducida");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Tamaño no válido. Se han borrado los datos de la canción introducida");
            }
        }
        else
        {
            Console.WriteLine("No se pueden añadir más canciones");
        }
    }
}
