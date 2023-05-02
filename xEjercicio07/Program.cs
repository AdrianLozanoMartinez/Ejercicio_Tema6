namespace xEjercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperaturas = "temperaturas.dat";
            int tempMax = int.MinValue;
            DateTime dateMax = DateTime.MinValue;

            if(Path.Exists(temperaturas))
            {
                using (StreamReader stream = new StreamReader(temperaturas))
                {
                    string line;
                    while((line = stream.ReadLine()) != null)
                    {
                        //Console.WriteLine(stream.ReadToEnd());
                        string[] valores = line.Split(" ");
                        int temp = int.Parse(valores[1]);
                        DateTime time = DateTime.Parse(valores[0]);

                        if(temp > tempMax)
                        {
                            tempMax = temp;
                            dateMax = time;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No existe");
            }
                    Console.WriteLine(tempMax + " " + dateMax);
        }
    }
}