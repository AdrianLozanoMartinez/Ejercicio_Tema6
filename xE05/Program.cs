namespace xE05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca ruta de fichero");
            string fichero = Console.ReadLine();

            if (Path.Exists(fichero))
            {
               using (StreamReader streamReader = new StreamReader(fichero))
                {
                    Console.WriteLine(streamReader.ReadToEnd());
                }
            }
        }
    }
}