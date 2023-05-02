namespace Ejercicio06;
/*Ejercicio 6.
Crea un programa de consola que pida al usuario un texto. Luego, crea un archivo de texto
y, usando el mismo Stream, escribe en dicho archivo el texto introducido por el usuario y
posteriormente, lee el fichero desde el principio y muestra su contenido. Finalmente muestra
por pantalla el tamaño del fichero en bytes*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca un texto");
        string texto = Console.ReadLine();

        string fichero = @"C:\Users\Sodert\Desktop\codigo.txt";
        using StreamWriter file = File.CreateText(fichero);
        file.WriteLine(texto);

        //Falta leer y mostrar contenido + tamaño de bytes

        file.Close();
    }
}