namespace xE04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre del archivo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();
            string archivo = nombre + ".txt";

            using (StreamWriter sr = new StreamWriter(archivo))
            {
                sr.Write(texto);
            }

            using (StreamReader streamReader = new StreamReader(archivo))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }
    }
}