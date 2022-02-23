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
			string? userInput;

			Console.WriteLine("Bitte ID eingeben: ");
			userInput = Console.ReadLine();
			int parsedID = int.Parse(userInput!);
			bool isValid = int.TryParse(userInput, out int parsedID1);
			if (isValid) {Id = parsedID1;}

			Console.WriteLine("Bitte Kundennummer eingeben: ");
			userInput = Console.ReadLine();
			int parsedCN = int.Parse(userInput!);
			isValid = int.TryParse(userInput, out int parsedCN1);
			if (isValid) { CustomerNumber = parsedCN1; }

			Console.WriteLine("Geben sie ihren vollen Namen ein: ");
			userInput = Console.ReadLine();
			Name = userInput;

			Console.WriteLine("Geben sie ihre Postleitzahl ein: ");
			userInput = Console.ReadLine();
			Zipcode = userInput;

			//TO-DO: Country

			Console.WriteLine("Geben sie ihre Straße ein: ");
			userInput = Console.ReadLine();
			Street = userInput;

			Console.WriteLine("Geben sie ihre Stadt ein: ");
			userInput = Console.ReadLine();
			City = userInput;
		}

		public void ausgeben()
        {
			Console.WriteLine(Id);
			Console.WriteLine(CustomerNumber);
			Console.WriteLine(Name);
			Console.WriteLine(Zipcode);
			//Console.WriteLine(Country);
			Console.WriteLine(Street);
			Console.WriteLine(City);
        }

		public void execute() 
		{
			saveUserData();
			ausgeben();
		}
	}
}