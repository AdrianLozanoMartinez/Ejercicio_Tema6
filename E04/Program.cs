using System.Reflection;

namespace E04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca nombre de archivo");
            string archivo = Console.ReadLine();
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();

            string archivoGenerado = archivo + ".txt";

            using (StreamWriter stream = new StreamWriter(archivoGenerado))
            {
                stream.WriteLine(texto);
            }

            using (StreamReader stream = new StreamReader(archivoGenerado))
            {
                Console.WriteLine(stream.ReadLine());
            }

        }
    }
}