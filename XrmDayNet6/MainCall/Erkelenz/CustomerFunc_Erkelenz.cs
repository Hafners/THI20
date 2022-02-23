using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.Data.Erkelenz.Enumerations;

namespace XrmDay.MainCall.Erkelenz
{
    public class CustomerFunc_Erkelenz
    {
        ContactPersonFunc_Erkelenz contactPersonFunc = new ContactPersonFunc_Erkelenz();

        public void DatenEinlesen(Customer_Erkelenz customer)
        {
            // id
            string ungueltig = "Eingabe ungültig";
            Console.Write("Id: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedId)) { customer.Id = parsedId; }
            else { Console.WriteLine(ungueltig); }

            // customerNumber
            Console.Write("Customer Number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedNumber)) { customer.CustomerNumber = parsedNumber; }
            else { Console.WriteLine(ungueltig); }

            // name
            Console.Write("Name: ");
            customer.Name = Console.ReadLine();

            // zipcode
            Console.Write("Zipcode: ");
            customer.Zipcode = Console.ReadLine();

            // country
            Console.Write("Country (Germany, England, Austria, Brazil): ");
            if (Enum.TryParse(Console.ReadLine(), out Country_Erkelenz parsedCountry)) { customer.Country = parsedCountry; }
            else { Console.WriteLine(ungueltig); }

            // street
            Console.Write("Street: ");
            customer.Street = Console.ReadLine();

            // city
            Console.Write("City: ");
            customer.City = Console.ReadLine();

            // contact person
            customer.ContactPersons = new List<ContactPerson_Erkelenz>();
            int count = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Add Contact Person? (Type 'Exit' to cancel) ");
            string inputContact = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (inputContact != "Exit")
            {
                Console.ForegroundColor = ConsoleColor.White;
                ContactPerson_Erkelenz contactPerson = new ContactPerson_Erkelenz();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------\nContact Person " + ++count + ": ");
                contactPersonFunc.DatenEinlesen(contactPerson);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.White;
                customer.ContactPersons.Add(contactPerson);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Add Contact Person? (Type 'Exit' to cancel) ");
                Console.ForegroundColor = ConsoleColor.Gray;
                inputContact = Console.ReadLine();
            }
        }

        public void DatenAusgeben(Customer_Erkelenz customer)
        {
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Customer Number: " + customer.CustomerNumber);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Zipcode: " + customer.Zipcode);
            Console.WriteLine("Country: " + customer.Country);
            Console.WriteLine("Street: " + customer.Street);
            Console.WriteLine("City: " + customer.City);
            int count = 0;
            foreach (ContactPerson_Erkelenz contactPerson in customer.ContactPersons)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contact Person " + ++count + ": ");
                contactPersonFunc.DatenAusgeben(contactPerson);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
            }
        }

    }
}