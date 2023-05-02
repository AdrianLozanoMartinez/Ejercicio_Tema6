namespace Ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "temperaturas.dat";
            int maxTemperature = int.MinValue;
            DateTime dateMaxTemperature = DateTime.MinValue;
           
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    DateTime date = DateTime.Parse(parts[0]);
                    int temperature = int.Parse(parts[1]);
                    if (temperature > maxTemperature)
                    {
                        maxTemperature = temperature;
                        dateMaxTemperature = date;
                    }
                }
            }

            Console.WriteLine($"El día con la temperatura más alta ({maxTemperature} grados) fue: {dateMaxTemperature.ToShortDateString()}.");

            /*El programa utiliza la clase StreamReader para leer el archivo de texto línea por línea. 
             * Para cada línea, se divide la cadena en dos partes utilizando string.Split(), y se convierte 
             * la primera parte en una fecha DateTime utilizando DateTime.Parse(). La segunda parte se 
             * convierte en un entero utilizando int.Parse(). Si la temperatura es mayor que la temperatura 
             * máxima actual, se actualizan las variables maxTemperature y dateMaxTemperature.

            Finalmente, se muestra el día con la temperatura más alta utilizando Console.WriteLine().*/
        }
    }
}