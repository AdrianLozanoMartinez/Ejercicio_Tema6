using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Ejercicio09
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				 Delimiter = ",",
				 HasHeaderRecord = true,
			};

			using StreamReader streamReader = new StreamReader("people.csv"); 
			using CsvReader csvReader = new CsvReader(streamReader, configuration);

			var personita = csvReader.GetRecords<Persona>();

			personita = personita.Where(x => x.Name.Length < 10);

			foreach(var persona in personita) { Console.WriteLine(persona.Name); }

			CsvConfiguration configuration2 = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				Delimiter = ","
			};

			using StreamWriter streamWriter = new StreamWriter("people2.csv");
			using CsvWriter csvWrite = new CsvWriter(streamWriter, configuration2);

			csvWrite.WriteRecords(personita);
        }
	}
}