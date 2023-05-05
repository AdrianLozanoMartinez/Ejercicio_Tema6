using System.Text;

namespace XxEjercicio06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca un texto");
			string texto = Console.ReadLine();
			string archivo = @"archivo.txt";
			Encoding encoding = Encoding.UTF8;

			using(Stream sr = new FileStream(archivo, FileMode.Create))
			{
				byte[] crearByte = encoding.GetBytes(texto);
				sr.Write(crearByte, 0, crearByte.Length);
			}
			using(Stream sr = new FileStream(archivo, FileMode.Open))
			{
				byte[] leerByte = new byte[sr.Length];
				sr.Read(leerByte, 0, leerByte.Length);

				string a = encoding.GetString(leerByte);

				Console.WriteLine(a);
                Console.WriteLine(a.Length);
			}

		}
	}
}