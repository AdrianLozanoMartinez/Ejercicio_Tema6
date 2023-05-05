namespace XxEjercicio07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string temperaturas = "temperaturas.dat";
			int tempMax = int.MinValue;
			DateOnly dateMax = DateOnly.MinValue;

			using (StreamReader sr = new StreamReader(temperaturas))
			{
                //Console.WriteLine(sr.ReadToEnd());

				string line;

				while((line = sr.ReadLine()) != null)
				{
					//Console.WriteLine(line);
					string[] part = line.Split(' ');
					//Console.WriteLine(part[0]);
					//Console.WriteLine(part[1]);
					DateOnly date = DateOnly.Parse(part[0]);
					int temp = int.Parse(part[1]);

					if(temp > tempMax)
					{
						tempMax = temp;
						dateMax = date;
					}
                }
                Console.WriteLine("Temperatura máxima " + tempMax + " el día " + dateMax);
            }
		}
	}
}