namespace E02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cosas = @"D:\Cosas";
            string otrasCosas = $@"{cosas}\Otras cosas";

            if (!Path.Exists(cosas))
            {
                Directory.CreateDirectory(otrasCosas);
                Console.WriteLine(otrasCosas + " creada el día: " + Directory.GetCreationTime(otrasCosas));
            }
            else
            {
                Console.WriteLine("Ya existe");
            }
            //Así lo puedo probar exista o no
            Directory.Delete(cosas, true);
        }
    }
}