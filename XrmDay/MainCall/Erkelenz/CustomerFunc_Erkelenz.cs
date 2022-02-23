using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.Data.Erkelenz.Enumerations;

namespace XrmDay.MainCall.Erkelenz
{
    public class CustomerFunc_Erkelenz
    {
        ContactPersonFunc_Erkelenz contactPersonFunc = new ContactPersonFunc_Erkelenz();

        public void datenEinlesenCustomer(Customer_Erkelenz customer)
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
            string inputContact = Console.ReadLine();
            while (inputContact != "Exit")
            {
                ContactPerson_Erkelenz contactPerson = new ContactPerson_Erkelenz();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------\nContact Person " + ++count + ": ");
                contactPersonFunc.datenEinlesenContactPerson(contactPerson);
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.White;
                customer.ContactPersons.Add(contactPerson);
                inputContact = Console.ReadLine();
            }
        }

        public void datenAusgebenCustomer(Customer_Erkelenz customer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nId: " + customer.Id);
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
                contactPersonFunc.datenAusgebenContactPerson(contactPerson);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}