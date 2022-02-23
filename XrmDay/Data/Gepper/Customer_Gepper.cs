using System;
using System.Collections.Generic;
using System.Text;


namespace XrmDay.Data
{
    class main_Gepper
	{
		public int Id { get; set; } = 0;

		public int CustomerNumber { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Zipcode { get; set; } = string.Empty;

		public enum Country
		{
			Germany,
			England,
			Austria,
			Brasil
		};

		public Country country { get; set; } = Country.Germany;

		public string Street { get; set; } = string.Empty;

		public string City { get; set; } = string.Empty;

		public void saveUserData()
		{
			Console.WriteLine("Geben sie ihren vollen Namen ein: ");
			string? userInput = Console.ReadLine();
			Name = userInput;

			Console.WriteLine("Geben sie ihre Postleitzahl ein: ");
			userInput = Console.ReadLine();
			Zipcode = userInput;

			Console.WriteLine("Geben sie ihre Straße ein: ");
			userInput = Console.ReadLine();
			Street = userInput;

			Console.WriteLine("Geben sie ihre Stadt ein: ");
			userInput = Console.ReadLine();
			City = userInput;
		}

		public void ausgeben()
        {
			Console.WriteLine(Name);
			Console.WriteLine(Zipcode);
			//Console.WriteLine(Country);
			Console.WriteLine(Street);
			Console.WriteLine(City);
        }
	}
}