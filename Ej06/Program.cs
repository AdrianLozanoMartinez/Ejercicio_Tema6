using System.Text; //Necesario para el encoding
namespace Ej06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un texto:");
            string texto = Console.ReadLine();

            string archivo = "archivo.txt";
            Encoding encoding = Encoding.UTF8;
            using (Stream stream = new FileStream(archivo, FileMode.Create))
            {
                byte[] datosByte = encoding.GetBytes(texto);
                stream.Write(datosByte, 0, datosByte.Length);
            }

            Console.WriteLine("Contenido del archivo:");
            using (Stream stream = new FileStream(archivo, FileMode.Open))
            {
                byte[] datosByte = new byte[stream.Length];
                stream.Read(datosByte, 0, datosByte.Length);
                //string textoSalida = System.Text.Encoding.UTF8.GetString(datosByte);
                string textoSalida = encoding.GetString(datosByte);
                Console.WriteLine(textoSalida);
            }

            FileInfo archivoSalida = new FileInfo(archivo);
            Console.WriteLine($"Tamaño del archivo: {archivoSalida.Length} bytes");

            /*En este caso, se utiliza FileStream para crear el archivo, pero se declara como tipo Stream, 
             * que es una clase abstracta base para todas las operaciones de entrada/salida. Para escribir 
             * el texto introducido por el usuario, se convierte el texto en una matriz de bytes utilizando 
             * System.Text.Encoding.UTF8.GetBytes(), y luego se escribe esa matriz de bytes en el archivo 
             * utilizando Stream.Write().

            Para leer el archivo, se crea un nuevo FileStream utilizando el mismo nombre de archivo y modo 
            de apertura "Open". A continuación, se lee todo el contenido del archivo en una matriz de bytes 
            utilizando Stream.Read(), y se convierte la matriz de bytes en una cadena utilizando System.Text.
            Encoding.UTF8.GetString(). Finalmente, se muestra la cadena resultante por pantalla.

            La última sección del código utiliza FileInfo para obtener información sobre el archivo, como su 
            tamaño en bytes, que se muestra en la última línea.*/


            /*SIN USAR SOLO STREAM*/
            /*Console.WriteLine("Introduce un texto:");
            string inputText = Console.ReadLine();

            string filePath = "archivo.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write(inputText);
                }
            }

            Console.WriteLine("Contenido del archivo:");
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }

            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"Tamaño del archivo: {fileInfo.Length} bytes");*/

            /*El programa comienza pidiendo al usuario que introduzca un texto mediante la función Console.ReadLine().
             * Luego, crea un archivo de texto llamado "archivo.txt" usando FileStream y StreamWriter, y 
             * escribe el texto introducido por el usuario en el archivo.

            Después, el programa lee el contenido del archivo creado usando FileStream y StreamReader, y lo 
            muestra por pantalla utilizando Console.WriteLine().

            Finalmente, el programa utiliza FileInfo para obtener información sobre el archivo, incluyendo 
            su tamaño en bytes, que se muestra en la última línea.

            Ten en cuenta que el programa siempre creará un archivo nuevo con el nombre "archivo.txt" en el 
            directorio 
            en el que se está ejecutando. Si deseas cambiar el nombre o la ubicación del archivo, o permitir
            al usuario especificar el nombre y la ubicación del archivo, puedes modificar el código en 
            consecuencia.*/
        }
    }
}