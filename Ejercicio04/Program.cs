namespace Ejercicio04;
/*Ejercicio 4.
Crea un programa de consola que pida al usuario el nombre de un archivo y un texto. El
programa creará un nuevo archivo de texto que tendrá como nombre el nombre que
introdujo el usuario y como contenido el texto*/
class Program
{//NO SE USA USING Y CLOSE, UNO U OTRO, USING ES AUTOMATICO Y CLOSE MANUAL, USING DEBE SABER DONDE ACABA
    static void Main()
    {
        Console.WriteLine("Introduzca el nombre de un archivo");
        string nombre = Console.ReadLine();

        Console.WriteLine("Introduzca un texto");
        string texto = Console.ReadLine();

        try
        {
            using FileStream fichero = File.Open(nombre, FileMode.CreateNew); //crea fichero
            using StreamWriter streamWriter = new StreamWriter(fichero);
            streamWriter.Write(texto);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}