namespace xEjercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre del archivo");
            string archiv = Console.ReadLine();
            string archivo = archiv + ".txt";
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();

            using (FileStream nombre = File.Open(archiv, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(nombre))
                {
                    sw.WriteLine(texto);
                }
            }
            using (FileStream nombre = File.Open(archiv, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(nombre))
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}