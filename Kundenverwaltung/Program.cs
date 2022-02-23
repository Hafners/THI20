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
using Data;
using System;

/*2. Schreibe eine Methode, womit über die Konsole die Daten eingelesen werden können.*/

/*
Console.WriteLine("Bitte gib dein alter ein");
Console.ReadLine();
string? userInput = Console.ReadLine();

int parsedAge = int.Parse(userInput);
bool isValid = int.TryParse(userInput, out int parsedAge1);
if (isValid)
{
    instance1.Age = parsedAge;
    instance1.Age
}
*/
Kunde_Customer kunde1_herrmann = new Kunde_Customer();

kunde1_herrmann.saveUserData();

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


}