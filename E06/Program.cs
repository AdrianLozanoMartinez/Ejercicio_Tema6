using System.Reflection;
using System.Text;

namespace E06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();

            string archivo = @"texto.txt";

            Encoding encoding = Encoding.UTF8;

            using (Stream stream = new FileStream(archivo, FileMode.Create) )
            {
                byte[] byteArchivo = encoding.GetBytes( texto );
                stream.Write(byteArchivo, 0, byteArchivo.Length );
            }
            using (Stream stream = new FileStream(archivo, FileMode.Open))
            {
                byte[] byteArchivo = new byte[stream.Length];
                stream.Read(byteArchivo, 0, byteArchivo.Length);
                
                string escrito = encoding.GetString(byteArchivo);
                Console.WriteLine(escrito);
            }

            FileInfo arc = new FileInfo(archivo);
            Console.WriteLine(arc + " con: " + arc.Length);
        }
    }
}