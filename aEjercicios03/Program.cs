namespace aEjercicios03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca un directorio");
			string directorio = Console.ReadLine();

			if (Directory.Exists(directorio))
			{
				IEnumerable<string> directory = Directory.GetDirectories(directorio);
				foreach (string dir in directory) Console.WriteLine(dir);

				var dire = Directory.GetFiles(directorio, "*.pdf", SearchOption.AllDirectories);
				foreach(string dir in dire) Console.WriteLine(dir);

                //var directory2 = Directory.GetFiles(directorio, "*.pdf", SearchOption.AllDirectories);
                //foreach ( var file in directory2) Console.WriteLine(file);

            }
		}
	}
}