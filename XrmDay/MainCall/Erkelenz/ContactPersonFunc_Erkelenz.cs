using System;
using System.Collections.Generic;
using System.Globalization;
using XrmDay.Data.Erkelenz;

namespace XrmDay.MainCall.Erkelenz
{
    public class ContactPersonFunc_Erkelenz
    {
        OrderFunc_Erkelenz orderFunc = new OrderFunc_Erkelenz();
        public void DatenEinlesen(ContactPerson_Erkelenz contact)
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
            Console.Write("Birthday (dd.mm.yyyy): ");
            string format = "dd.MM.yyyy";
            userInput = Console.ReadLine();
            if (DateTime.TryParseExact(userInput, format, new CultureInfo("de-DE"), DateTimeStyles.None, out DateTime parsedDate)) { contact.Birthday = parsedDate; }
            else { Console.WriteLine(ungueltig); }

            // order
            contact.Orders = new List<Order_Erkelenz>();
            int count = 0;
            string inputOrder = Console.ReadLine();
            while (inputOrder != "Exit")
            {
                Order_Erkelenz order = new Order_Erkelenz();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------\nOrder Position " + ++count + ": ");
                orderFunc.DatenEinlesen(order);
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.White;
                contact.Orders.Add(order);
                inputOrder = Console.ReadLine();
            }
        }

        public void DatenAusgeben(ContactPerson_Erkelenz contact)
        {
            Console.WriteLine("\nId: " + contact.Id);
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.WriteLine("Birthday: " + contact.Birthday.ToString("dd.MM.yyyy"));

            int count = 0;
            foreach (Order_Erkelenz order in contact.Orders)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Order " + ++count + ": ");
                orderFunc.DatenAusgeben(order);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
            }
        }

    }
}
