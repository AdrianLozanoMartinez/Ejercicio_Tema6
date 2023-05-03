namespace xE03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //D:\Documentos\DAW
            Console.WriteLine("Introduzca un directorio");
            string directorio = Console.ReadLine();

            if(Directory.Exists(directorio))
            {
                IEnumerable<string> directory = Directory.GetDirectories(directorio);
                foreach (string file in directory)
                {
                    //Vemos subcarpetas
                    IEnumerable<string> directory2 = Directory.GetDirectories(file);
                    //Console.WriteLine(file);
                    foreach (string file2 in directory2)
                    {
                        Console.WriteLine(file2);
                    }
                }

                //Archivo solo en la carpeta, no subcarpeta
                //IEnumerable<string> archivo = Directory.GetFiles(directorio);
                //foreach(string arch in archivo) Console.WriteLine(arch);

                DirectoryInfo director = new DirectoryInfo(directorio);
                var a = director.GetFiles("*.pdf", SearchOption.AllDirectories);
                foreach(var file in a) Console.WriteLine(file);


            }
        }
    }
}