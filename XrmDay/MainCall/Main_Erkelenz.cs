using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.Data.Erkelenz.Enumerations;

namespace XrmDay.MainCall
{
    public class main_Erkelenz
    {
        public void datenEinlesenContactPerson(ContactPerson_Erkelenz contact)
        {
            string ungueltig = "Eingabe ungültig";
            string userInput;
            // id
            Console.Write("Id: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedId)) { contact.Id = parsedId; }
            else { Console.WriteLine(ungueltig); }

            // first name
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            // last name
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            // birthday
            Console.Write("Birthday: ");
        }
        public void datenAusgebenContactPerson(ContactPerson_Erkelenz contact)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nId: " + contact.Id);
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.ForegroundColor = ConsoleColor.White;
        }
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
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void execute()
        {
            Console.ForegroundColor = ConsoleColor.White;
            List<Customer_Erkelenz> kunden = new List<Customer_Erkelenz>();
            string userInput = String.Empty;
            int count = 0;
            while (userInput != "Exit")
            {
                Customer_Erkelenz kunde = new Customer_Erkelenz();
                Console.WriteLine("--------\nKunde " + ++count + ": ");
                datenEinlesenCustomer(kunde);
                kunden.Add(kunde);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
                userInput = Console.ReadLine();
            }
            count = 0;
            foreach (Customer_Erkelenz customer in kunden)
            {
                Console.Write("--------\nKunde " + ++count + ": ");
                datenAusgebenCustomer(customer);
                Console.WriteLine("--------\n");
            }
        }
    }
}
