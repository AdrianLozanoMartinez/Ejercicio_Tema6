using CsvHelper.Configuration.Attributes;

namespace Ejercicio09
{
	internal class Persona
	{
		[Name("id")]
		public int Id { get; set; }
		[Name("name")]
		public string Name { get; set; }
		[Name("country")]
		public string Country { get; set; }
		public string Phone { get; set; }
		[Name("e-mail")]
		public string Email { get; set; }
	}
}
