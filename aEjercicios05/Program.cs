namespace aEjercicios05
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("fichero");
			string fichero = Console.ReadLine();

			if (Path.Exists(fichero))
			{
				using (StreamReader sr = new StreamReader(fichero))
				{
                    Console.WriteLine(sr.ReadToEnd());
                }
			}
			else Console.WriteLine("No existe");
        }
	}
}