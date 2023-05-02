namespace Ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un nombre para el archivo");
            string nombreArchivo = Console.ReadLine();
            string nA = nombreArchivo + ".txt";
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();

            using (FileStream stream = File.Open(nA, FileMode.OpenOrCreate))
            {
                using StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.Write(texto);
            }
            

        }
    }
}