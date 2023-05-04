namespace aEjercicios07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string temperatura = "temperaturas.dat";
			int tempMax = int.MinValue;
			DateOnly dateMax = DateOnly.MinValue;

			if(Path.Exists(temperatura))
			{
				using (StreamReader sr = new StreamReader(temperatura))
				{
                    //Console.WriteLine(sr.ReadToEnd());

					string line;
					while((line = sr.ReadLine()) != null)
					{
                        //Console.WriteLine(line);
						string[] strings = line.Split(' ');
						int temp = int.Parse(strings[1]);
						DateOnly date = DateOnly.Parse(strings[0]);

                        //Console.WriteLine(temp);
						if(temp > tempMax)
						{
							dateMax = date;
							tempMax = temp;
						}

                    }
                }
			}
            Console.WriteLine(dateMax + " " + tempMax);
		}
	}
}