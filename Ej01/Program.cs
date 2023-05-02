namespace Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca ruta de fichero");
            string fichero = Console.ReadLine();

            //C:\Users\Sodert\Desktop\resumen.cs
            string sinExtension = Path.GetFileNameWithoutExtension(fichero);
            Console.WriteLine(sinExtension);

            string extension = Path.GetExtension(fichero);
            Console.WriteLine(extension);

            //Estudiar este punto
            string directorio = Path.GetDirectoryName(fichero); 
            string coger = Path.GetFileName(directorio);
            Console.WriteLine(coger);

            string cambio = Path.ChangeExtension(fichero, ".mp3");
            Console.WriteLine(cambio);

            string absoluta = Path.GetFullPath(fichero);
            Console.WriteLine(absoluta);
        }
    }
}