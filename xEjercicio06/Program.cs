using System.Text;

namespace xEjercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();
            string fichero = "archivo.txt";
            Encoding encoding = Encoding.UTF8;

            using (Stream stream = new FileStream (fichero, FileMode.Create))
            {
                byte[] byteNombre = encoding.GetBytes (texto);
                stream.Write(byteNombre, 0, byteNombre.Length);
            }
            using (Stream stream = new FileStream (fichero, FileMode.Open))
            {
                byte[] byteNom = new byte[stream.Length];
                stream.Read(byteNom, 0, byteNom.Length);

                string nom = encoding.GetString (byteNom);
                Console.WriteLine(nom);
            }
            Console.WriteLine(fichero.Length);

       
        }
    }
}