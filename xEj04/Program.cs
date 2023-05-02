namespace xEj04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre de un archivo");
            string archiv = Console.ReadLine();
            Console.WriteLine("Introduce un texto");
            string texto = Console.ReadLine();

            string archivo = archiv + ".txt";

            using (StreamWriter stream = new StreamWriter(archivo))
            {
                stream.WriteLine(texto);
            }
            using (StreamReader stream = new StreamReader(archivo))
            {
                Console.WriteLine(stream.ReadToEnd());
            }
        }
    }
}