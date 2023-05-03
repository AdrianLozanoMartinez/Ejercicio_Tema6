using System.IO;
using System.Text;

namespace RepeatEj06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un texto");
            string texto = Console.ReadLine();

            string arch = "archivo.txt";
            Encoding encoding = Encoding.UTF8;

            using (Stream stream = new FileStream(arch, FileMode.Create))
            {
                byte[] b = encoding.GetBytes(texto);
                stream.Write(b, 0, b.Length);
            }
            using (Stream stream = new FileStream(arch, FileMode.Open))
            {
                byte[] b = new byte[stream.Length];
                stream.Read(b, 0, b.Length);

                string a = encoding.GetString(b);
                Console.WriteLine(a);
                Console.WriteLine(arch.Length);
            }
            Console.WriteLine(arch.Length);

        }
    }
}