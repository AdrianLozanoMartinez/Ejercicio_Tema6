namespace XxEjercicio05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca una ruta de un fichero");
			string fichero = Console.ReadLine();

			if(Path.Exists(fichero))
			{
				using(StreamReader sr = new StreamReader(fichero))
				{
                    Console.WriteLine(sr.ReadToEnd());
                }
			}
		}
	}
}