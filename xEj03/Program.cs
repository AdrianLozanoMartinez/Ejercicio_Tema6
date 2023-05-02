namespace xEj03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una ruta de un directorio");
            string directorioUrl = Console.ReadLine();

            if(Directory.Exists(directorioUrl))
            {
                IEnumerable<string> todas = Directory.GetDirectories(directorioUrl);
                foreach(string s in todas) { Console.WriteLine(s); }

                DirectoryInfo directoryInfo = new DirectoryInfo(directorioUrl);
                var a = directoryInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
                foreach(FileInfo f in a) { Console.WriteLine(f); }
            }
        }
    }
}