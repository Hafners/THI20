using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.Data.Erkelenz.Enumerations;

namespace XrmDay.MainCall
{
    public class main_Erkelenz
    {
        public void datenEinlesen(Customer_Erkelenz customer)
        {
            // id
            string ungueltig = "Eingabe ungültig";
            Console.Write("Id: ");
            string? userInput = Console.ReadLine();
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

            datenAusgeben(customer);
        }
        public void datenAusgeben(Customer_Erkelenz customer)
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
            string? userInput = String.Empty;
            int count = 0;
            while (userInput != "Exit")
            {
                Customer_Erkelenz kunde = new Customer_Erkelenz();
                Console.WriteLine("--------\nKunde " + ++count + ": ");
                datenEinlesen(kunde);
                kunden.Add(kunde);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
                userInput = Console.ReadLine();
            }
            count = 0;
            foreach (Customer_Erkelenz customer in kunden)
            {
                Console.Write("--------\nKunde " + ++count + ": ");
                datenAusgeben(customer);
                Console.WriteLine("--------\n");
            }
        }
    }
}
