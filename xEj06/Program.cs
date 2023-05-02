using System.Text;

namespace xEj06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            string text = Console.ReadLine();
            string archivo = "archivo.txt";
            Encoding encoding = Encoding.UTF8;

            using (Stream stream = new FileStream(archivo, FileMode.Create))
            {
                byte[] nombreByte = encoding.GetBytes(text);
                stream.Write(nombreByte, 0, nombreByte.Length);
            }
            using (Stream stream = new FileStream(archivo, FileMode.Open))
            {
                byte[] nomByte = new byte[stream.Length];
                stream.Read(nomByte, 0, nomByte.Length);

                string tex = encoding.GetString(nomByte);
                Console.WriteLine(tex);
            }
            Console.WriteLine(archivo.Length);
        }
    }
}