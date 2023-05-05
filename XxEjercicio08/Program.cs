using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace XxEjercicio08
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string regex = "regex.txt";

			using(StreamReader sr = new StreamReader(regex))
			{
				string fichero = sr.ReadToEnd();
                Console.WriteLine(fichero);

                Console.WriteLine("*************************************************************");
                Console.WriteLine();
                Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"i\"");
				Regex regex1 = new Regex(@"\bi\w+");
				MatchCollection match1 = regex1.Matches(fichero);
				foreach (Match match in match1) Console.WriteLine(match);
				Console.WriteLine();


				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que no tengan número");
				Regex regex2 = new Regex(@"[A-Za-zá-úÁ-Ú]*");
				//GetAndShowResult(text, @"[^(\d+)]+"); -> Esto y más mirarlo en sus respuestas
				MatchCollection match2 = regex2.Matches(fichero);
				foreach(Match match in match2) Console.Write(match + " ");


				Console.WriteLine();



				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que contengan la letra \"o\" y terminen con la letra \"n\"");
				Regex regex3 = new Regex(@"\w*o\w*n\b");
				MatchCollection match3 = regex3.Matches(fichero);
				foreach(Match match in match3) Console.WriteLine(match);

				Console.WriteLine();



				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que tengan más de 5 letras");
				Regex regex4 = new Regex(@"\w{6,}");
				MatchCollection match4 = regex4.Matches(fichero);
				foreach(Match match in match4) Console.WriteLine(match);

                Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que tengan una letra en mayúscula al principio");
				Regex regex5 = new Regex(@"[A-Z]+\w*");
				MatchCollection match5 = regex5.Matches(fichero);
				foreach(Match match in match5) Console.WriteLine(match);


				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que contengan la letra \"t\" y la letra \"o\"");
				Regex regex6 = new Regex(@"\w*(t\w*o|o\w*t)\w*");
				MatchCollection match6 = regex6.Matches(fichero);
				foreach(Match match in match6) Console.WriteLine(match);

				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que contengan la letra \"t\" o la letra \"o\"");
				//Regex regex7 = new Regex(@"\w*(t|o)\w*");
				Regex regex7 = new Regex(@"\w*[to]\w*");
				MatchCollection match7 = regex7.Matches(fichero);
				foreach(Match match in match7) Console.WriteLine(match);


				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que contengan un punto \".\"");
				//Regex regex8 = new Regex(@"\w*[.]\w*");
				Regex regex8 = new Regex(@"\w*\.\w*");
				MatchCollection match8 = regex8.Matches(fichero);
				foreach(Match match in match8) Console.WriteLine(match);


				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"s\" y tengan al menos una letra \"a\"");
				Regex regex9 = new Regex(@"\b[Ss]\w*a\w*");
				MatchCollection match9 = regex9.Matches(fichero);
				foreach(Match match in match9) Console.WriteLine(match);

				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"b\" y terminen con la letra \"s\" o la letra \"n\"");
				Regex regex10 = new Regex(@"\b[Bb]\w*[sn]\b");
				MatchCollection match10 = regex10.Matches(fichero);
				foreach(Match match in match10) Console.WriteLine(match);

				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todas las palabras que contengan un número después de un signo de dólar \"$\"");
				Regex regex11 = new Regex(@"\w*\$\d+\.*\d*\w*");
				MatchCollection match11 = regex11.Matches(fichero);
				foreach(Match match in match11) Console.WriteLine(match);

				Console.WriteLine();

				Console.WriteLine("*************************************************************");
				Console.WriteLine();
				Console.WriteLine("Encuentra todos los números que estén seguidos por la palabra \"billones\"");
				Regex regex12 = new Regex(@"\$\d+(\.\d+)?\sbillones");
				MatchCollection match12 = regex12.Matches(fichero);
				foreach(Match match in match12) Console.WriteLine(match);

				Console.WriteLine();
			}
		}
	}
}