using System;

Console.WriteLine("Bitte gib eine Id ein");
string userInputId = Console.ReadLine();

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