namespace aEjercicios01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//C:\Users\Sodert\Desktop\Estudiar hoy.txt
			Console.WriteLine("Introduzca una ruta de un fichero");
			string fichero = Console.ReadLine();

            Console.WriteLine(Path.GetFileNameWithoutExtension(fichero));
            Console.WriteLine(Path.GetExtension(fichero));
            Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(fichero)));
            Console.WriteLine(Path.ChangeExtension(fichero, ".pm3"));
            Console.WriteLine(Path.GetFullPath(fichero));
        }
	}
}