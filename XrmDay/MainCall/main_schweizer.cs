using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.MainCall
{
    internal class main_schweizer
    {
        public void Execute()
        {
            int weiter = 0;
            do {
                XrmDay.Customer_Schweizer customer = new XrmDay.Customer_Schweizer();
                // ID
                Console.WriteLine("Bitte gib eine Id ein");
                string? userInput = Console.ReadLine();

                bool isValid = int.TryParse(userInput, out int parsedID);
                if (isValid)
                {
                    customer.ID = parsedID;
                }

                // CustomerNummer
                Console.WriteLine("Bitte gib eine CustomerNumber ein");
                userInput = Console.ReadLine();

                isValid = int.TryParse(userInput, out int parsedCustNum);
                if (isValid)
                {
                    customer.CustomerNumber = parsedCustNum;
                }

                // Name
                Console.WriteLine("Bitte gib einen Namen ein");
                userInput = Console.ReadLine();
                customer.Name = userInput;

                // Zipcode
                Console.WriteLine("Bitte gib einen Zipcode ein");
                userInput = Console.ReadLine();
                customer.Zipcode = userInput;

                // Country 
                Console.WriteLine("Bitte gib ein Country ein");
                userInput = Console.ReadLine();

                isValid = Data.Schweizer.enumerations.Country.TryParse(userInput, out Data.Schweizer.enumerations.Country parsedCountry);
                if (isValid)
                {
                    switch (parsedCountry)
                    {
                        case (Data.Schweizer.enumerations.Country)0:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)1:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)2:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)3:
                            customer.Land = parsedCountry;
                            break;
                    }
                }

                // Street
                Console.WriteLine("Bitte gib eine Street ein");
                userInput = Console.ReadLine();
                customer.Street = userInput;

                // City
                Console.WriteLine("Bitte gib eine City ein");
                userInput = Console.ReadLine();
                customer.City = userInput;

                // Konsole Textfarbe verändern
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("ID: " + customer.ID);
                Console.WriteLine("CustomerNumber: " + customer.CustomerNumber);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Zipcode: " + customer.Zipcode);
                Console.WriteLine("Country: " + customer.Land);
                Console.WriteLine("Street: " + customer.Street);
                Console.WriteLine("City: " + customer.City);

                Console.WriteLine("Nochmal Customer eingeben (1=ja, 0=nein): ?");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int paredDO);

                if (isValid)
                {
                    weiter = 1;
                }
            } while (weiter == 1);
         }
    }
}
