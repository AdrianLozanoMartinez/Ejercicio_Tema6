namespace Ejercicio05;
/*Ejercicio 5.
Crea un programa de consola que pida al usuario la ruta de un fichero. Si el archivo existe
se mostrará por consola su contenido. En el caso de que no exista se notificará al usuario*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca la ruta de un fichero");
        string fichero = Console.ReadLine();

        try 
        { 
            if(File.Exists(fichero))
            {
                using StreamReader lector = File.OpenText(fichero); //Abrimos fichero
                string texto = lector.ReadToEnd(); //La lectura la metemos en una variable para luego mostrarla
                Console.WriteLine(texto);
                lector.Close();
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}