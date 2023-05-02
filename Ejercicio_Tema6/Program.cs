namespace Ejercicio01;

internal class Program
{
    static void Main()
    {
        //NO SON FICHERO REAL, COGE DE STRING
        Console.WriteLine("Introduzca la ruta del fichero");
        string directorio = Console.ReadLine(); //C:\Users\Sodert\Desktop\Licencia.pdf

        Console.WriteLine();

        //El nombre del archivo sin la extensión
        Console.WriteLine(Path.GetFileNameWithoutExtension(directorio));

        //La extensión del archivo
        Console.WriteLine(Path.GetExtension(directorio));

        //El nombre de la carpeta (no la ruta de la carpeta) donde se encuentra el archivo
        Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(directorio)));
        //Te da el directorio entero -> GetDirectoryName
        //Del directorio que te da se coge el archivo, en este caso el último directorio -> GetFileName

        //La ruta del archivo pero con la extensión cambiada a mp3
        Console.WriteLine(Path.ChangeExtension(directorio,".mp3"));

        //La ruta absoluta del nombre del archivo con su extensión.
        Console.WriteLine(Path.GetFullPath(directorio));

    }
}