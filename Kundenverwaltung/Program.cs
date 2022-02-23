
using Data;
using System;


void datenEinlesen(Customer customer)
{
//id
Console.Write("Id: ");
string? userInput = Console.ReadLine();
if (int.TryParse(userInput, out int parsedId))
{
customer.Id = parsedId;
}
else { Console.WriteLine("Eingabe ungültig!"); }

//customerNumber
Console.Write("Customer Number: ");
userInput = Console.ReadLine();
if (int.TryParse(userInput, out int parsedNumber))
{
customer.CustomerNumber = parsedNumber;
}
else { Console.WriteLine("Eingabe ungültig!"); }

//name
Console.Write("Name: ");
customer.Name = Console.ReadLine();

//zipcode
Console.Write("Zipcode: ");
customer.Zipcode = Console.ReadLine();

// country
Console.Write(
    "Countries(Zahl eingeben):" +
     "\nGermany => 0" +
     "\nEngland => 1 " +
     "\nAustria => 2" +
     "\nBrasil => 3"
     );

Console.Write("Country: ");
customer.City = Console.ReadLine();
if (customer.City < 0 && customer.City > 3)
{
Console.Write("Fehler.");
}
else
{
Console.Write(customer.City);
}

Console.ForegroundColor = ConsoleColor.Red;
}

void DataAusgeben(Customer customer)
{
Console.Write("Daten die ausgelesen wurden...");
Console.Write("Id" + id);
}


class Customer
{

    public int Id { get; set; }
    public int CustomerNumber { get; set; }
    public string Name { get; set; }
    public string Zipcode { get; set; }
    public enum Country
    {
        Germany = 0,
        England = 1,
        Austria = 2,
        Brasil = 3
    }
    public string Street { get; set; }
    public string City { get; set; }




};



