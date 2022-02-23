using XrmDay.Data.Heimbach;
using System;
using System.Collections.Generic;

namespace XrmDay.MainCall
{
    public class main_Heimbach
    {
        public void execute()
        {
            string weiter = "j";

            List<Customer_Heimbach> customerList = new List<Customer_Heimbach>();
            Customer_Heimbach customer = new Customer_Heimbach;
            while(counter != exit)
            {
                customer.datenEinlesen();
                customerList.Add(customer);
                Console.WriteLine("Weiteren Kunden eingeben (j) oder beenden (exit): ");
                weiter = Console.ReadLine();
            }
            Console.WriteLine("Einlesen beendet.");
            for(int i = 0; i < customerList.Count; ++i)
            {
                datenAusgeben(customerList[i]);
            }
        }
    }
}
