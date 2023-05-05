namespace XxEjercicio03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca un directorio");
			string directorio = Console.ReadLine();

			if(Directory.Exists(directorio))
			{
				IEnumerable<string> directory = Directory.GetDirectories(directorio);
				foreach(string dir in directory) Console.WriteLine(dir);

				DirectoryInfo directoryInfo = new DirectoryInfo(directorio);
				var dire = directoryInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
				foreach(var file in dire) Console.WriteLine(file);
            }
		}
	}
}