namespace xEj07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperatura = "temperaturas.dat";
            int tempMax = int.MinValue;
            DateOnly dateOnly = DateOnly.MinValue;

            using (StreamReader stream = new StreamReader(temperatura))
            {
                //Console.WriteLine(stream.ReadToEnd());
                string line;
                while((line = stream.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    string[] parte = line.Split(" ");
                    DateOnly date = DateOnly.Parse(parte[0]);
                    int temp = int.Parse(parte[1]);
                    //Console.WriteLine(date + " " + temp);

                    if(temp > tempMax)
                    {
                        tempMax = temp;
                        dateOnly = date;
                    }
                }
            }
            Console.WriteLine(tempMax + " " + dateOnly);
        }
    }
}