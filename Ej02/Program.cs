namespace Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = @"D:\Cosas";
            string url2 = $@"{url}\Otras cosas";

            if (!Directory.Exists(url2))
            {
                DirectoryInfo dire = Directory.CreateDirectory(url2);
                Console.WriteLine(dire + " " + Directory.GetCreationTime(url2));
                Directory.Delete(@"D:\Cosas", true);
            }
        }
    }
}