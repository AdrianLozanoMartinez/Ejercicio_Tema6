namespace E03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una ruta de un directorio");
            string directorio = Console.ReadLine();

            try
            {
                if (Path.Exists(directorio))
                {
                    IEnumerable<string> direc = Directory.GetDirectories(directorio);
                    foreach (string dir in direc) { Console.WriteLine(dir); }

                    DirectoryInfo nombre = new DirectoryInfo(directorio);
                    var di = nombre.GetFiles("*.pdf", SearchOption.AllDirectories);
                    foreach (var dir in di) { Console.WriteLine(dir); }

                }
                else
                {
                    Console.WriteLine("No es un directorio");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}