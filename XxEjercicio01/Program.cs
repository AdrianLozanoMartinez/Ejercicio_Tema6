namespace XxEjercicio01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduce un fichero");
			string fichero = Console.ReadLine();

            Console.WriteLine(Path.GetFileNameWithoutExtension(fichero));
            Console.WriteLine(Path.GetExtension(fichero));
            Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(fichero)));
            Console.WriteLine(Path.ChangeExtension(fichero, ".mp3"));
            Console.WriteLine(Path.GetFullPath(fichero));
            Console.WriteLine(Path.GetFullPath(Path.GetFileName(fichero)));
        }
	}
}