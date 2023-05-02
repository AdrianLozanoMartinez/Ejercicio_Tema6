namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca ruta de fichero");
            string fichero = Console.ReadLine();

            if(File.Exists(fichero))
            {
                using (StreamReader stream = new StreamReader(fichero))
                {
                    string leer = stream.ReadToEnd();
                    Console.WriteLine(leer);
                }
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
    }
}