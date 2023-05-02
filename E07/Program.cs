namespace E07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archiv = @"temperaturas.dat";
            int tempMax = int.MinValue;
            DateTime tiempMax = DateTime.MinValue;

            
            using (StreamReader reader = new StreamReader(archiv))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] part = line.Split(" ");
                    int temp = int.Parse(part[1]);
                    DateTime tiempo = DateTime.Parse(part[0]);
                    
                    if(temp > tempMax)
                    {
                        tempMax = temp;
                        tiempMax = tiempo;
                    }
                }
            }

            Console.WriteLine(tempMax + " " + tiempMax);
        }
    }
}