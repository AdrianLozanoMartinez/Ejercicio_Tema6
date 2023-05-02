namespace xEj01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un nombre de ruta de fichero");
            string fichero = Console.ReadLine();

            //C:\Users\Sodert\Desktop\Estudiar hoy.txt

            Console.WriteLine(Path.GetFileNameWithoutExtension(fichero));
            Console.WriteLine(Path.GetExtension(fichero));
            Console.WriteLine(Path.GetDirectoryName(fichero));
            Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(fichero)));
            Console.WriteLine(Path.ChangeExtension(fichero, ".mp3"));
            Console.WriteLine(Path.GetFullPath(fichero));

        }
    }
}