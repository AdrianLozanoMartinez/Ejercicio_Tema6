namespace xE07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperatura = "temperaturas.dat";
            int tempMax = int.MinValue;
            DateOnly dateMax = DateOnly.MinValue;

            using (StreamReader stream = new StreamReader(temperatura))
            {
                //Console.WriteLine(stream.ReadToEnd());

                string line;

                while((line = stream.ReadLine()) != null)
                {
                    string[] strings = line.Split(" ");
                    //Console.WriteLine(strings[0]);
                    DateOnly date = DateOnly.Parse(strings[0]);
                    int temp = int.Parse(strings[1]);

                    if(temp > tempMax)
                    {
                        tempMax = temp;
                        dateMax = date;
                    }
                }
                Console.WriteLine(tempMax + " " + dateMax);
            }
        }
    }
}