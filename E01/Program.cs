namespace E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una ruta de un fichero");
            string ruta = Console.ReadLine();

            string sinExtension = Path.GetFileNameWithoutExtension(ruta);
            Console.WriteLine(sinExtension);

            string extension = Path.GetExtension(ruta);
            Console.WriteLine(extension);

            string url = Path.GetDirectoryName(ruta);
            Console.WriteLine(url);
            string nombreCarpeta = Path.GetFileName(url);
            Console.WriteLine(nombreCarpeta);

            string cambio = Path.ChangeExtension(ruta, ".mp3");
            Console.WriteLine(cambio);

            string absoluta = Path.GetFullPath(ruta);
            Console.WriteLine(absoluta);
        }
    }
}