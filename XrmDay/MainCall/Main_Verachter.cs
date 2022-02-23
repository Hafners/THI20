using XrmDay.Data.Verachter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace XrmDay.MainCall
{
    public class Main_Verachter
    {
        List<Customer> customers = new List<Customer>();
        Customer kunde = new Customer();
        ContactPerson kontakt = new ContactPerson();
        List<ContactPerson> cPerson = new List<ContactPerson>();

        public void einlesenKunde() {

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
            Console.WriteLine("Wollen Sie den Kunden ausgeben? (j/n)");
            string aw = Console.ReadLine();
            if(aw.ToLower() == "j")
            {
                ausgebenKunde();
            }
            customers.Add(kunde);
        }


        public void einlesenKontakt()
        {
            Console.WriteLine("Geben Sie eine ID an:");
            string i = Console.ReadLine();
            bool isValid = int.TryParse(i, out int parsedId);
            if (isValid)
            {
                kontakt.Id = parsedId;
            }

            Console.WriteLine("Geben Sie einen Vornamen an:");
            string fn = Console.ReadLine();
            kontakt.FirstName = fn;

            Console.WriteLine("Geben Sie einen Nachnamen an:");
            string cn = Console.ReadLine();
            kontakt.LastName = cn;

            Console.WriteLine("Geben Sie das Geburtsdatum an: (DD/MM/YYYY)");
            string inputDate = Console.ReadLine();
            DateTime.TryParse(inputDate, out DateTime parsedDate);
            kontakt.Birthday = parsedDate;

            Console.WriteLine("Wollen Sie den Kontakt ausgeben? (j/n)");
            string aw = Console.ReadLine();
            if (aw.ToLower() == "j")
            {
                ausgebenKontakt();
            }
            cPerson.Add(kontakt);

        }

        public void ausgebenKunde()
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

        public void ausgebenKontakt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id = " + kunde.Id);
            Console.WriteLine("Firstname = " + kontakt.FirstName);
            Console.WriteLine("Lastname = " + kontakt.LastName);
            Console.WriteLine("Birthday = " + kontakt.Birthday);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void execute() {

            string inputKunde = String.Empty;
            string inputKontakt = String.Empty;
            do {

                Console.WriteLine("Wollen Sie einen Kunden anlegen? ('Exit' zum beenden)");
                inputKunde = Console.ReadLine();
                if (inputKunde.ToLower() == "ja")
                {
                    einlesenKunde();
                }

                Console.WriteLine("Wollen Sie einen Kontakt anlegen? ('Exit' zum beenden)");
                inputKontakt = Console.ReadLine();
                if (inputKontakt.ToLower() == "ja")
                {
                    einlesenKontakt();
                }

            } while (!string.Equals(inputKunde, "exit", StringComparison.OrdinalIgnoreCase) && 
                    !string.Equals(inputKontakt, "exit", StringComparison.OrdinalIgnoreCase));

        }
    }

}
