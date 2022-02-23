using XrmDay.Data.Verachter;
using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.MainCall
{
    public class Main_Verachter
    {
        Data.Verachter.Customer verachter = new Customer();

        public void einlesen() {

            Console.WriteLine("Geben Sie eine ID an:");
            string? i = Console.ReadLine();
            bool isValid = int.TryParse(i, out int parsedId);
            if (isValid)
            {
                verachter.Id = parsedId;
            }

            Console.WriteLine("Geben Sie eine KundenNummer an:");
            string? kdNr = Console.ReadLine();
            isValid = int.TryParse(kdNr, out int parsedkdNr);
            if (isValid)
            {
                verachter.CustomerNumber = parsedkdNr;
            }

            Console.WriteLine("Geben Sie einen Namen an:");
            string? n = Console.ReadLine();
            verachter.Name = n;

            Console.WriteLine("Geben Sie die PLZ an:");
            string? zipC = Console.ReadLine();
            verachter.Zipcode = zipC;

            Console.WriteLine("Geben Sie die Strasse an:");
            string? str = Console.ReadLine();
            verachter.Street = str;

            Console.WriteLine("Geben Sie die Stadt an:");
            string? cit = Console.ReadLine();
            verachter.City = cit;

            Console.WriteLine("Geben Sie das Land an: (0 = Deutschland, 1 = England, 2 = Oestterreich, 3 = Brasilien)");
            string? enumId = Console.ReadLine();
            isValid = Data.Verachter.Enumerations.Country.TryParse(kdNr, out Data.Verachter.Enumerations.Country parsedEnumId);
            if (isValid)
            {
                switch (parsedEnumId)
                {
                    case (Data.Verachter.Enumerations.Country)0:
                        verachter.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)1:
                        verachter.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)2:
                        verachter.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)3:
                        verachter.Country = parsedEnumId;
                        break;
                    default:
                        Console.WriteLine("Geben Sie ein vordefiniertes Land an!");
                        break;
                }
            }
        }

        public void ausgeben()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id = "+ verachter.Id);
            Console.WriteLine("CustomerNumber = "+ verachter.CustomerNumber);
            Console.WriteLine("Name = "+ verachter.Name);
            Console.WriteLine("Zipcode = "+ verachter.Zipcode);
            Console.WriteLine("Country = "+ verachter.Country.ToString());
            Console.WriteLine("Street = "+ verachter.Street);
            Console.WriteLine("City = "+ verachter.City);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void execute() {
            string? input = String.Empty;
            do {
                Console.WriteLine("Wollen Sie einen Kunden anlegen?");
                input = Console.ReadLine();
                if (input.ToLower() == "ja")
                {
                    einlesen();
                    ausgeben();
                }
            } while (input != "Exit");

        }
    }

}
