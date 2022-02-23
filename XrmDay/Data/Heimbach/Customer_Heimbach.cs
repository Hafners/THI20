using System;

public class Class1
{
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        enum Country { Germany, England, Austria, Brazil }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        void datenEinlesen(Customer);
        void datenAusgeben(Customer);
    }
}


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
    Console.WriteLine("Country (0 = Germany, 1 = England, 2 = Austria, 3 = Brasil): ")
    userInput = Console.ReadLine();
    if (int.TryParse(userInput, out int parsedCountry))
    {
        customer.Country = parsedCountry;
    }
    else { Console.WriteLine("Ungültige Eingabe"};

    //street
    Console.WriteLine("Street: ");
    customer.street = Console.ReadLine();

    //city
    Console.WriteLine("City: ");
    customer.city = Console.ReadLine();
}


void datenAusgeben(Customer customer)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Id: " + customer.Id);
    Console.WriteLine("Number: " + customer.CustomerNumber);
    Console.WriteLine("Name: " + customer.Name);
    Console.WriteLine("Street: " + customer.Street);
    Console.WriteLine("Zipcode: " + customer.Zipcode);
    Console.WriteLine("City: " + customer.City);
    Console.WriteLine("Country: " + customer.Country);
    Console.ForegroundColor = ConsoleColor.White;
}
