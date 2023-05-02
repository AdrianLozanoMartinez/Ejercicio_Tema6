namespace Ejercicio02;
/*Ejercicio 2.
Crea un programa de consola que en el método principal cree, si no existe, una carpeta
llamada “Cosas”. A la hora de crear dicha carpeta tendrá que tener dentro otra carpeta
llamada “Otras cosas” y se mostrará por pantalla el día y hora de creación. Finalmente borra
la carpeta “Cosas” con todo su contenido.
*/
class Program
{
    static void Main()
    {
        string usuario = "Sodert";
        string cosas = $@"C:\Users\{usuario}\Desktop\Cosas";
        string otrasCosas = $@"{cosas}\Otras cosas";

        if (!Directory.Exists(cosas))
        {
            Directory.CreateDirectory(otrasCosas); //Al crear la última se crea la anterior automáticamente
            Console.WriteLine(Directory.GetCreationTime(otrasCosas)); //Se crean la hora y día
            Directory.Delete(cosas, true); //borra todo y tru sus contenidos, he tenido que dividir en dos carpetas
            //diferentes porque al borrar solo borraba la última, de este modo borro la de arriba con todos sus descendientes
        }
        

    }
}