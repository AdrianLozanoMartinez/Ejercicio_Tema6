namespace xEj02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cosas = @"D:\Cosas";
            string otrasCosas = $@"{cosas}\Otras cosas";

            if (!Path.Exists(cosas))
            {
                Directory.CreateDirectory(cosas);
                Console.WriteLine(Directory.GetCreationTime(cosas));
            }
            else
            {
                Console.WriteLine("Existe, la borramos");
                Directory.Delete(cosas);
            }
        }
    }
}