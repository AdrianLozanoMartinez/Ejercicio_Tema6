namespace XxEjercicio04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Elija nombre de archivo");
			string nombreArchivo = Console.ReadLine();
			string archivo = nombreArchivo + ".txt";
            Console.WriteLine("Introduzca texto");
			string texto = Console.ReadLine();

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