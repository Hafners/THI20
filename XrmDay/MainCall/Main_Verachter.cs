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
        Order order = new Order();
        OrderPosition orderPosition = new OrderPosition();

        public void einlesenKunde() {

            Console.WriteLine("Geben Sie eine KundenID an:");
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
            Console.WriteLine("Geben Sie eine KontaktID an:");
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

            Console.WriteLine("Geben Sie das Geburtsdatum an: (MM/DD/YYYY)");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime parsedBirthday))
            {
                kontakt.Birthday = parsedBirthday;
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            

            Console.WriteLine("Wollen Sie den Kontakt ausgeben? (j/n)");
            string aw = Console.ReadLine();
            if (aw.ToLower() == "j")
            {
                ausgebenKontakt();
            }
            kunde.cPerson.Add(kontakt);
        }

        public void einlesenBestellung()
        {
            Console.WriteLine("Geben Sie die BestellID ein:");
            string inputId = Console.ReadLine();
            bool isValid = int.TryParse(inputId, out int parsedId);
            if (isValid)
            {
                order.Id = parsedId;
            }

            Console.WriteLine("Geben Sie die BestellID ein:");
            string inputSum = Console.ReadLine();
            isValid = decimal.TryParse(inputId, out decimal parsedSum);
            if (isValid)
            {
                order.SummaryAmount = parsedSum;
            }

            Console.WriteLine("Geben Sie das Bestelldatum an: (MM/DD/YYYY)");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime parsedDate))
            {
                order.OrderDate = parsedDate;
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }

            Console.WriteLine("Wollen Sie die Bestellung ausgeben? (j/n)");
            string aw = Console.ReadLine();
            if (aw.ToLower() == "j")
            {
                ausgebenBestellung();
            }
            orders.Add(order);
        }

        public void einlesenBestellposition()
        {
            Console.WriteLine("Geben Sie die BestellPositionsID ein:");
            string inputId = Console.ReadLine();
            bool isValid = int.TryParse(inputId, out int parsedId);
            if (isValid)
            {
                orderPosition.Id = parsedId;
            }

            Console.WriteLine("Geben Sie die Arikelnummer ein:");
            string inputArticelNr = Console.ReadLine();
            isValid = int.TryParse(inputArticelNr, out int parsedArticelNr);
            if (isValid)
            {
                orderPosition.Id = parsedArticelNr;
            }

            Console.WriteLine("Geben Sie die Arikelnummer ein:");
            string inputAmount = Console.ReadLine();
            isValid = decimal.TryParse(inputAmount, out decimal parsedAmount);
            if (isValid)
            {
                orderPosition.Amount = parsedAmount;
            }

            Console.WriteLine("Wollen Sie die BestellungPosition ausgeben? (j/n)");
            string aw = Console.ReadLine();
            if (aw.ToLower() == "j")
            {
                ausgebenBestellposition();
            }
            orderPositions.Add(orderPosition);



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
            Console.WriteLine("Id = " + kontakt.Id);
            Console.WriteLine("Firstname = " + kontakt.FirstName);
            Console.WriteLine("Lastname = " + kontakt.LastName);
            Console.WriteLine("Birthday = " + kontakt.Birthday);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public void ausgebenBestellung()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id = " + order.Id);
            Console.WriteLine("SummaryAmmount = " + order.SummaryAmount);
            Console.WriteLine("OrderDate = " + order.OrderDate);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ausgebenBestellposition()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id = " + orderPosition.Id);
            Console.WriteLine("Articlenumber = " + orderPosition.ArticleNumber);
            Console.WriteLine("Amount = " + orderPosition.Amount);
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void execute() {

            string inputKunde = String.Empty;
            string inputKontakt = String.Empty;
            string inputOrder = String.Empty;
            string inputOrderposition = String.Empty;

            bool run = true;

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

                Console.WriteLine("Wollen Sie eine Bestellung anlegen? ('Exit' zum beenden)");
                inputOrder = Console.ReadLine();
                if (inputOrder.ToLower() == "ja")
                {
                    einlesenBestellung();
                }

                Console.WriteLine("Wollen Sie eine Bestellposition anlegen? ('Exit' zum beenden)");
                inputOrderposition = Console.ReadLine();
                if (inputOrderposition.ToLower() == "ja")
                {
                    einlesenBestellposition();
                }

                run = !(string.Equals(inputKunde, "exit", StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(inputKontakt, "exit", StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(inputOrder, "exit", StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(inputOrderposition, "exit", StringComparison.OrdinalIgnoreCase));

           } while (run);

        
        
        }
    }

}
