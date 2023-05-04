using System.Text;

namespace aEjercicios06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca texto");
			string texto = Console.ReadLine();

			Encoding encoding = Encoding.UTF8;
			string archivoTexto = "archivoTexto.txt";

			using (Stream stream = new FileStream(archivoTexto, FileMode.Create))
			{
				byte[] byteNombre = encoding.GetBytes(texto);
				stream.Write(byteNombre, 0, byteNombre.Length);
			}
			using (Stream stream = new FileStream(archivoTexto, FileMode.Open))
			{
				byte[] nombreByte = new byte[stream.Length];
				stream.Read(nombreByte, 0, nombreByte.Length);

                string nombre = encoding.GetString(nombreByte);
                Console.WriteLine(nombre);
                Console.WriteLine(nombreByte.Length);
			}
		}
	}
}