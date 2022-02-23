using XrmDay.Data.Kain;
using System;
using System.Collections.Generic;

namespace XrmDay.MainCall
{
    public class main_Kain
    {
        public void execute()
        {


int temp = 0;

List<Customer_Kain> customerList = new List<Customer_Kain>();

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Customer_Kain instance1 = new Customer_Kain();

    Console.WriteLine("Bitte ID eingeben: ");
    string? userInput = Console.ReadLine();

    int parsedID = int.Parse(userInput!);
    bool isValid = int.TryParse(userInput, out int parsedID1);
    if (isValid)
    {
        instance1.Id = parsedID1;
    }

    Console.WriteLine("Bitte CustomerNumber eingeben: ");
    userInput = Console.ReadLine();

    int parsedCN = int.Parse(userInput!);
    isValid = int.TryParse(userInput, out int parsedCN1);
    if (isValid)
    {
        instance1.CustomerNumber = parsedCN1;
    }

    Console.WriteLine("Bitte Name eingeben: ");
    userInput = Console.ReadLine();
    instance1.Name = userInput!;

    Console.WriteLine("Bitte Postleitzahl eingeben: ");
    userInput = Console.ReadLine();
    instance1.Zipcode = userInput!;

    Console.WriteLine("Bitte Stadt eingeben: ");
    userInput = Console.ReadLine();
    instance1.City = userInput!;

    Console.WriteLine(
        "Bitte Land auswählen:\n0 = Germany\n1 = England\n2 = Austria\n3 = Brasil\nBei fehlerhafter Angabe: Germany");
    userInput = Console.ReadLine();


    int parsedCT = int.Parse(userInput!);
    isValid = int.TryParse(userInput, out int parsedCT1);
    if (isValid)
    {
        switch (parsedCT1)
        {
            case 0:
                instance1.country = Customer_Kain.Country.Germany;
                break;
            case 1:
                instance1.country = Customer_Kain.Country.England;
                break;
            case 2:
                instance1.country = Customer_Kain.Country.Austria;
                break;
            case 4:
                instance1.country = Customer_Kain.Country.Brasil;
                break;
            default:
                instance1.country = Customer_Kain.Country.Germany;
                break;
        }
    }


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ID: " + instance1.Id);
    Console.WriteLine("CustomerNumber: " + instance1.CustomerNumber);
    Console.WriteLine("Name: " + instance1.Name);
    Console.WriteLine("Postleitzahl: " + instance1.Zipcode);
    Console.WriteLine("Stadt: " + instance1.City);
    Console.WriteLine("Land: " + instance1.country);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Weiteren Kunden hinzufügen? [ja = 1 | nein = 0]");
    userInput = Console.ReadLine();
    int parsedS = int.Parse(userInput!);
    isValid = int.TryParse(userInput, out int parsedS1);
    if (isValid)
    {
        temp = parsedS1;
    }
    else
    {
        Console.WriteLine("Fehlerhafte Eingabe... Programm wird beendet");
        temp = 0;
    }
    customerList.Add(instance1);
} while (temp != 0);
        }
    }
}