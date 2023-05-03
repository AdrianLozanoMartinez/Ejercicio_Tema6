namespace xE01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Sodert\Desktop\Referencia catastral.txt
            Console.WriteLine("Introduzca una ruta de archivo");
            string ruta = Console.ReadLine();

            Console.WriteLine(Path.GetFileNameWithoutExtension(ruta));
            Console.WriteLine(Path.GetExtension(ruta));
            Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(ruta)));
            Console.WriteLine(Path.ChangeExtension(ruta,".mp3"));
            Console.WriteLine(Path.GetFullPath(ruta));
        }
    }
}