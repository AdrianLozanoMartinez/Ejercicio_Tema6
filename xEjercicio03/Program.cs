namespace xEjercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca dirección de un directorio");
            string directorio = Console.ReadLine();

            if(Path.Exists(directorio))
            {
                IEnumerable<string> directory = Directory.GetDirectories(directorio);
                foreach( string file in directory ) { Console.WriteLine(file); }
              
                DirectoryInfo directoryInfo = new DirectoryInfo(directorio);
                var nombre = directoryInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
                foreach( var file in nombre ) {  Console.WriteLine(file); }
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
    }
}