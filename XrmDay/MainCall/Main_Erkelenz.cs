using System;
using System.Collections.Generic;
using XrmDay.Data.Erkelenz;
using XrmDay.MainCall.Erkelenz;

namespace XrmDay.MainCall
{
    public class main_Erkelenz
    {
        CustomerFunc_Erkelenz customerFunc = new CustomerFunc_Erkelenz();
        public void execute()
        {
            Console.ForegroundColor = ConsoleColor.White;
            List<Customer_Erkelenz> kunden = new List<Customer_Erkelenz>();
            string userInput = String.Empty;
            int count = 0;
            while (userInput != "Exit")
            {
                Customer_Erkelenz kunde = new Customer_Erkelenz();
                Console.WriteLine("----------\nKunde " + ++count + ": ");
                customerFunc.datenEinlesen(kunde);
                kunden.Add(kunde);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------\n");
                userInput = Console.ReadLine();
            }
            count = 0;
            foreach (Customer_Erkelenz customer in kunden)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kunde " + ++count + ": ");
                customerFunc.datenAusgeben(customer);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------\n");
            }
        }
    }
}
