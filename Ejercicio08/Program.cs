using System.Text.RegularExpressions;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fichero = "regex.txt";
            string patron1 = @"\bi\w*"; //\b comienzo de palabra. \w todas las letras y números y * coja todos

            

            using (StreamReader sr = new StreamReader(fichero))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    //1. Encuentra todas las palabras que comiencen con la letra "i"
                    Regex regex = new Regex(patron1);
                    MatchCollection matchCollection = regex.Matches(line);
                    foreach (Match match in matchCollection) Console.WriteLine("Valor " + match.Value + " posición " + match.Index);

                }
            }
        }
    }
}