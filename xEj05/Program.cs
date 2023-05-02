namespace xEj05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la ruta de un fichero");
            string fichero = Console.ReadLine();    

            if(Path.Exists(fichero))
            {
                StreamReader sr = new StreamReader(fichero);
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}