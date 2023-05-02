namespace RepeatEj03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce directorio");
            string directorio = Console.ReadLine();

            if(Directory.Exists(directorio))
            {
                IEnumerable<string> directorios = Directory.GetDirectories(directorio);
                foreach(string dire in directorios) Console.WriteLine(dire);

                DirectoryInfo directoryInfo = new DirectoryInfo(directorio);
                var a = directoryInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
                foreach(var file in a) { Console.WriteLine(file); }
            }
        }
    }
}