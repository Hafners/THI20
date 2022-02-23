using XrmDay.Data.Verachter;
using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.MainCall
{
    public class Main_Verachter
    {
        List<Customer> customers = new List<Customer>();
        Data.Verachter.Customer kunde = new Customer();

        public void einlesen() {

            Console.WriteLine("Geben Sie eine ID an:");
            string i = Console.ReadLine();
            bool isValid = int.TryParse(i, out int parsedId);
            if (isValid)
            {
                kunde.Id = parsedId;
            }

            Console.WriteLine("Geben Sie eine KundenNummer an:");
            string kdNr = Console.ReadLine();
            isValid = int.TryParse(kdNr, out int parsedkdNr);
            if (isValid)
            {
                kunde.CustomerNumber = parsedkdNr;
            }

            Console.WriteLine("Geben Sie einen Namen an:");
            string n = Console.ReadLine();
            kunde.Name = n;

            Console.WriteLine("Geben Sie die PLZ an:");
            string zipC = Console.ReadLine();
            kunde.Zipcode = zipC;

            Console.WriteLine("Geben Sie die Strasse an:");
            string str = Console.ReadLine();
            kunde.Street = str;

            Console.WriteLine("Geben Sie die Stadt an:");
            string cit = Console.ReadLine();
            kunde.City = cit;

            Console.WriteLine("Geben Sie das Land an: (0 = Deutschland, 1 = England, 2 = Oestterreich, 3 = Brasilien)");
            string enumId = Console.ReadLine();
            isValid = Data.Verachter.Enumerations.Country.TryParse(kdNr, out Data.Verachter.Enumerations.Country parsedEnumId);
            if (isValid)
            {
                switch (parsedEnumId)
                {
                    case (Data.Verachter.Enumerations.Country)0:
                        kunde.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)1:
                        kunde.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)2:
                        kunde.Country = parsedEnumId;
                        break;
                    case (Data.Verachter.Enumerations.Country)3:
                        kunde.Country = parsedEnumId;
                        break;
                    default:
                        kunde.Country = Data.Verachter.Enumerations.Country.Germany;
                        break;
                }
            }
            ausgeben();
            customers.Add(kunde);
        }

        public void ausgeben()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id = "+ kunde.Id);
            Console.WriteLine("CustomerNumber = "+ kunde.CustomerNumber);
            Console.WriteLine("Name = "+ kunde.Name);
            Console.WriteLine("Zipcode = "+ kunde.Zipcode);
            Console.WriteLine("Country = "+ kunde.Country.ToString());
            Console.WriteLine("Street = "+ kunde.Street);
            Console.WriteLine("City = "+ kunde.City);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void execute() {

            string input = String.Empty;
            do {
                Console.WriteLine("Wollen Sie einen Kunden anlegen?");
                input = Console.ReadLine();
                if (input.ToLower() == "ja")
                {
                    einlesen();
                }
            } while (input != "Exit");

        }
    }

}
