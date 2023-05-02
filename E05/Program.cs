namespace E05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca ruta del fichero");
            string dire = Console.ReadLine();

            if(Path.Exists(dire))
            {
                StreamReader sr = new StreamReader(dire);
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}