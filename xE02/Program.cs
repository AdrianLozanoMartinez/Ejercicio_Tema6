using static System.Net.Mime.MediaTypeNames;

namespace xE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C: \Users\Sodert\Desktop\Referencia catastral.txt
            string cosas = @"D:\Cosas";
            string otrasCosas = $@"{cosas}\Otras cosas";

            if (!Directory.Exists(cosas))
            {
                Directory.CreateDirectory(cosas);
                Console.WriteLine(Directory.GetCreationTime(cosas));
            }
            else
            {
                Directory.Delete(cosas, true);
            }
        }
    }
}