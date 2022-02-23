using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.MainCall.Erkelenz;

namespace XrmDay.MainCall
{
    public class Main_Erkelenz
    {
        CustomerFunc_Erkelenz customerFunc = new CustomerFunc_Erkelenz();
        public void Execute()
        {
            List<Customer_Erkelenz> kunden = new List<Customer_Erkelenz>();
            string userInput = String.Empty;
            int count = 0;
            while (userInput != "Exit")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Customer_Erkelenz kunde = new Customer_Erkelenz();
                Console.WriteLine("----------\nKunde " + ++count + ": ");
                customerFunc.DatenEinlesen(kunde);
                kunden.Add(kunde);
                Console.WriteLine("--------\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Add Customer? (Type 'Exit' to cancel) ");
                userInput = Console.ReadLine();
            }
            count = 0;
            foreach (Customer_Erkelenz customer in kunden)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kunde " + ++count + ": ");
                customerFunc.DatenAusgeben(customer);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------\n");
            }
        }
    }
}
