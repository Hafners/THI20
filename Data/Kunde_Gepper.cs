/* 
* 1. Lege eine Klasse Customer im Projekt Data mit folgenden Properties an:
*	- Id int
*	- CustomerNumber int
*	- Name string
*	- Zipcode string
*	- Country enum
*		- Germany
*		- England
*		- Austria
*		- Brasil
*	- Street string
*	- City string
*/

using System;

namespace Data
{
	public class Kunde_Gepper
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

		public string Street { get; set; } = string.Empty;

		public string City { get; set; } = string.Empty;

		public void saveUserData()
		{
			Console.WriteLine("Geben sie ihren vollen Namen ein: ");
			Console.ReadLine();
			string? userInput = Console.ReadLine();
			Name = userInput;

		}
	}
}