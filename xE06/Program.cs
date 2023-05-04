using System.Globalization;
using System.IO;
using System.Text;

namespace xE06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();

            string fichero = "archivo.txt";
            Encoding encoding = Encoding.UTF8;

            using (Stream stream = new FileStream(fichero, FileMode.Create))
            {
                byte[] byteCreado = encoding.GetBytes(texto);
                stream.Write(byteCreado, 0, byteCreado.Length);
            }
            using (Stream stream = new FileStream(fichero, FileMode.Open))
            {
                byte[] byteCogido = new byte[stream.Length];
                stream.Read(byteCogido, 0, byteCogido.Length);

                string textito = encoding.GetString(byteCogido);
                Console.WriteLine(textito);
                Console.WriteLine(byteCogido.Length);
            }

        }
    }
}