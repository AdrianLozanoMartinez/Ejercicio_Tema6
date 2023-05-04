namespace aEjercicios02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string cosas = @"D:\Cosas";
			string otrasCosas = $@"{cosas}\Otras cosas";

			if(!Directory.Exists(cosas))
			{
				Directory.CreateDirectory(otrasCosas);
                Console.WriteLine(Directory.GetCreationTime(otrasCosas));
            }
			else
			{
				Directory.Delete(cosas, true);
			}
		}
	}
}