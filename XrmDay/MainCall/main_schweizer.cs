using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace XrmDay.MainCall
{
    internal class main_schweizer
    {
        public void Execute()
        {
            int weiter = 0;
            List<Customer_Schweizer> customerList = new List<Customer_Schweizer>();
            do {
                Customer_Schweizer customer = new Customer_Schweizer();
                // ID
                Console.WriteLine("Bitte gib eine Id ein");
                string userInput = Console.ReadLine();

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

                isValid = enumerations.Country.TryParse(userInput, out enumerations.Country parsedCountry);
                if (isValid)
                {
                    switch (parsedCountry)
                    {
                        case (enumerations.Country)0:
                            customer.Land = parsedCountry;
                            break;
                        case (enumerations.Country)1:
                            customer.Land = parsedCountry;
                            break;
                        case (enumerations.Country)2:
                            customer.Land = parsedCountry;
                            break;
                        case (enumerations.Country)3:
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

                Console.ForegroundColor= ConsoleColor.White;

                Console.WriteLine("Nochmal Customer eingeben (1=ja, 0=nein): ?");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int parsedDO);

                customerList.Add(customer);

                execute_ContactPerson();

                Console.ForegroundColor = ConsoleColor.Red;
                customer.ContactPersons.ForEach(contactPerson => Console.WriteLine(
                    " ID: " + contactPerson.ID +
                    " First Name: " + contactPerson.FirstName +
                    " Last Name: " + contactPerson.LastName +
                    " Birthday: " + contactPerson.Birthday));

                if (isValid && parsedDO ==1)
                {
                    weiter = 1;
                }
            } while (weiter == 1);
         }

        public void execute_ContactPerson()
        {
            int hilf_while = 0;
            do
            {
                ContactPerson_Schweizer contactPerson_Schweizer = new ContactPerson_Schweizer();

                // ID
                Console.WriteLine("Bitte gib eine ContactPerson ID ein");
                string userInput = Console.ReadLine();

                bool isValid = int.TryParse(userInput, out int parsedID);
                if (isValid)
                {
                    contactPerson_Schweizer.ID = parsedID;
                }

                // Vorname
                Console.WriteLine("Bitte gib einen first name ein");
                userInput = Console.ReadLine();
                contactPerson_Schweizer.FirstName = userInput;

                // Vorname
                Console.WriteLine("Bitte gib einen last name ein");
                userInput = Console.ReadLine();
                contactPerson_Schweizer.LastName = userInput;

                Customer_Schweizer customer_Schweizer = new Customer_Schweizer();
                customer_Schweizer.ContactPersons.Add(contactPerson_Schweizer);

                Console.WriteLine("Nochmal ContactPerson eingeben (1=ja, 0=nein): ?");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int parsedDO);

                if (isValid && parsedDO == 1)
                {
                    hilf_while = 1;
                }

            } while (hilf_while == 1);
        }
    }
}
