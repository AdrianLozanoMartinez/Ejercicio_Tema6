using System.IO;

namespace Ejercicio03
{
/*Ejercicio 3.
Crea un programa de consola que en el método principal pida una ruta de un directorio al
usuario. Si el directorio existe entonces se mostrará el listado de todas las carpetas que
haya en dicho directorio y luego se mostrará el listado de todos los archivos con formato pdf
que contenga el directorio y sus subdirectorios. En el caso de que la ruta introducida no
exista se debe notificar al usuario.*/
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca un directorio al usuario");
            string ruta = Console.ReadLine();

            if(Directory.Exists(ruta))
            {
                IEnumerable<string> directorios = Directory.GetDirectories(ruta); //Meto la ruta para saber que directorios hay dentro
                foreach (string directori in directorios)
                {
                    Console.WriteLine(directori);//Vemos directorios
                    //FUNCIONA EN EL EJ03
                    /*try
                    {
                        //Se ve los archivos si ponemos algo como:
                        //D:\Documentos\DAW\.NO ESTUDIAR\Convalido\Sistema\Tema 1
                        IEnumerable<string> archivo = Directory.EnumerateFiles(directori, "*.pdf");
                        foreach (string archiv in archivo)
                        {
                            Console.WriteLine(archiv);
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }*/

                }
            }
            else
            {
                Console.WriteLine("No existe la ruta");
            }    

        }
    }
}