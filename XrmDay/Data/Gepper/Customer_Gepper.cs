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

			Console.WriteLine(
					"Bitte Land auswählen:\n0 = Germany\n1 = England\n2 = Austria\n3 = Brasil\nBei fehlerhafter Angabe: Germany");
			userInput = Console.ReadLine();
			int parsedCT = int.Parse(userInput!);
			isValid = int.TryParse(userInput, out int parsedCT1);
			if (isValid)
			{
				switch (parsedCT1)
				{
					case 0:
						country = Country.Germany;
						break;
					case 1:
						country = Country.England;
						break;
					case 2:
						country = Country.Austria;
						break;
					case 4:
						country = Country.Brasil;
						break;
					default:
						country = Country.Germany;
						Console.WriteLine("Eingabe fehlerhaft, default wird verwendet: Germany");
						break;
				}
			}


			Console.WriteLine("Geben sie ihre Straße ein: ");
			userInput = Console.ReadLine();
			Street = userInput;

			Console.WriteLine("Geben sie ihre Stadt ein: ");
			userInput = Console.ReadLine();
			City = userInput;
		}

		public void ausgeben()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("ID: " + Id);
			Console.WriteLine("CustomerNumber: " + CustomerNumber);
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Postleitzahl: " + Zipcode);
			Console.WriteLine("Stadt: " + City);
			Console.WriteLine("Land: " + country);
		}
		public void execute() 
		{
			saveUserData();
			ausgeben();
		}
	}
}