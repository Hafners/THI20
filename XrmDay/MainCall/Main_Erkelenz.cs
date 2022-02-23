using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using XrmDay.Data.Erkelenz;
using XrmDay.MainCall.Erkelenz;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XrmDay.MainCall
{
    public class Main_Erkelenz
    {
        CustomerFunc_Erkelenz customerFunc = new CustomerFunc_Erkelenz();
        public void Execute()
        {
            List<Customer_Erkelenz> kunden;
            CustomerFunc_Erkelenz customerFunc = new CustomerFunc_Erkelenz();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer_Erkelenz>));
            const string path = "..\\..\\..\\Data\\Erkelenz\\Files\\";
            string fileName = "data.xml";

            if (File.Exists(path + fileName))
            {
                StreamReader file = new StreamReader(path + fileName);
                kunden = (List<Customer_Erkelenz>)xmlSerializer.Deserialize(file);
                file.Close();
            }
            else { kunden = new List<Customer_Erkelenz>(); }

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

            if (File.Exists(path + fileName)) { File.Delete(path + fileName); }
            TextWriter writer = new StreamWriter(path + fileName);
            xmlSerializer.Serialize(writer, kunden);
            writer.Close();

            fileName = "data.json";
            if (File.Exists(path + fileName)) { File.Delete(path + fileName); }
            File.WriteAllText(path + fileName, JsonSerializer.Serialize(kunden));
        }
    }
}