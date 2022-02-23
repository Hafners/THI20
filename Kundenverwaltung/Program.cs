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

    //? country
}


void datenAusgeben(Customer customer)
{
    Console.WriteLine("Id: " + customer.Id);
}

Customer c1 = new Customer();

class Customer
{
    private
    int ID;
    int customernumber;
    string name;
    string zipcode; 
    enum Country
    {
        Germany;
        England; 
        Austria; 
        Brasil; 
    }
    string street;
    string city;
    public void Methode()
    {
        Console.WriteLine("Bitte eine ID eingeben");

        string? userInput = Console.ReadLine();
    }


var b = 1;

}