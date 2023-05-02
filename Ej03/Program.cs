namespace Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una ruta de directorio");
            string dire = Console.ReadLine();

            if(Directory.Exists(dire))
            {
                IEnumerable<string> direc = Directory.EnumerateDirectories(dire);
                foreach(string s in direc) { Console.WriteLine(s); }

                //Todos los archivos pdf que se encuentra dentro de la carpeta y subcarpetas
                DirectoryInfo di = new DirectoryInfo(dire);
                var a = di.GetFiles("*.pdf", SearchOption.AllDirectories);
                foreach (var s in a) Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("No existe ruta");
            }
        }
    }
}