using System.Text.RegularExpressions;

namespace aEjercicios08
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string archivo = @"regex.txt";

			using (StreamReader stream = new StreamReader(archivo))
			{
				Console.WriteLine(stream.ReadToEnd());
				Console.WriteLine();
			}

			using (StreamReader stream = new StreamReader(archivo))
			{
					string line;
				while((line = stream.ReadLine()) != null)
				{
                    Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"i\"");
                    Regex regex1 = new Regex(@"\b[iI]\w*");
					MatchCollection match = regex1.Matches(line);
					foreach (Match m in match) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todas las palabras que no tengan número");
					Regex regex2 = new Regex(@"[a-zA-Zá-úÁ-Ú]*");
					MatchCollection match2 = regex2.Matches(line);
					foreach (Match m in match2) Console.Write(m + " ");

                    Console.WriteLine("\n");

                    Console.WriteLine("Encuentra todas las palabras que contengan la letra \"o\" y terminen con la letra \"n\"");
					Regex regex3 = new Regex(@"\w*[Oo]\w*[Nn]");
					MatchCollection match3 = regex3.Matches(line);
					foreach(Match m in match3) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todas las palabras que tengan más de 5 letras");
					Regex regex4 = new Regex(@"[\w*]{5,}");
					MatchCollection match4 = regex4.Matches(line);
					foreach(Match m in match4) Console.WriteLine(m);

					Console.WriteLine("Encuentra todas las palabras que tengan una letra en mayúscula al principio");
					Regex regex5 = new Regex(@"[A-Z]\w*");
					MatchCollection match5 = regex5.Matches(line);
					foreach (Match m in match5) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todas las palabras que contengan la letra \"t\" y la letra \"o\"");
					Regex regex6 = new Regex(@"\w*(t\w*o|o\w*t)\w*");
					MatchCollection match6 = regex6.Matches(line);
					foreach (Match m in match6) Console.WriteLine(m);

					Console.WriteLine("Encuentra todas las palabras que contengan la letra \"t\" o la letra \"o\"");
					Regex regex7 = new Regex(@"\w*(t|o)\w*");
					MatchCollection match7 = regex7.Matches(line);
					foreach (Match m in match7) Console.WriteLine(m);

					Console.WriteLine("Encuentra todas las palabras que contengan un punto \".\"");
					Regex regex8 = new Regex(@"[a-zA-Zá-úÁ-Ú]+\.");
					MatchCollection match8 = regex8.Matches(line);
					foreach(Match m in match8) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"s\" y tengan al menos una letra \"a\"");
					Regex regex9 = new Regex(@"\b[sS]\w*a\w*");
					MatchCollection match9 = regex9.Matches(line);
					foreach (Match m in match9) Console.WriteLine(m);

					Console.WriteLine("Encuentra todas las palabras que comiencen con la letra \"b\" y terminen con la letra \"s\" o la letra \"n\"");
					Regex regex10 = new Regex(@"\b[bB]\w*[sn]");
					MatchCollection match10 = regex10.Matches(line);
					foreach(Match m in match10) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todas las palabras que contengan un número después de un signo de dólar \"$\"");
					Regex regex11 = new Regex(@"\$\d*\.\d*");
					MatchCollection match11 = regex11.Matches(line);
					foreach (Match m in match11) Console.WriteLine(m);

                    Console.WriteLine("Encuentra todos los números que estén seguidos por la palabra \"billones\"");
					Regex regex12 = new Regex(@"\d+(,\d{3})*(\.\d+)?\s+billones");
					MatchCollection match12 = regex12.Matches(line);
					foreach( Match m in match12) Console.WriteLine(m);
                }
            }
		}
	}
}