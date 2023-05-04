namespace aEjercicios04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("nombre de archivo");
			string nombreArchivo = Console.ReadLine();
			Console.WriteLine("texto");
			string texto = Console.ReadLine();

			string archivo = nombreArchivo + ".txt";

			using (StreamWriter streamWriter = new StreamWriter(archivo))
			{
				streamWriter.Write(texto);
			}
			using (StreamReader streamReader = new StreamReader(archivo))
			{
                Console.WriteLine(streamReader.ReadToEnd());
            }
		}
	}
}