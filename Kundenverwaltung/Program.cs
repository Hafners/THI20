using Data;
using System;



class Customer
{
    
    int ID;
    int customernumber;
    string name;
    string zipcode; 
    enum Country
    {
        Germany = 0,
        England = 1, 
        Austria = 2, 
        Brasil = 3
    }
    string street;
    string city;
    string country; 
    public void Eingabe()
    {
        //ID-Eingabe 
        Console.Write("ID: ");
        string? userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int parsedId))
        {
            ID = parsedId;
        }
        else { Console.WriteLine("Eingabe ungültig!"); }


        //Customer-Nummer-Eingabe
        Console.Write("CustomerNummer: ");
        string? Customer = Console.ReadLine();
        if (int.TryParse(userInput, out int customersID))
        {
            customernumber = customersID; 
        }
        else { Console.WriteLine("Bitte gültiges Format für die Kundennummer eingeben!"); 
        }

        //Kundename Eingabe 
        Console.Write("Name: ");
        name = Console.ReadLine();

        //zipcode
        Console.Write("Zipcode: ");
        zipcode = Console.ReadLine();

        //ENUM-Eingabe 
        Console.Write("Germany = 0");
        Console.Write("England = 1"); 
        Console.Write("Austria = 2"); 
        Console.Write("Brasil = 3"); 

        string? userlanguage = Console.ReadLine();

        if (int.TryParse(userlanguage, out int CountryId))
        {
            if(CountryId == 0)
            {
                 country =  Country.Germany.ToString();
            }else if(CountryId == 1)
            {
               country =  Country.England.ToString(); 
            }else if(CountryId == 2)
            {
                country = Country.Austria.ToString(); 
            }else if(CountryId == 4)
            {
                country = Country.Brasil.ToString(); 
            }else
            {
                Console.Write("Ungültige Eingabe. Default wird auf Deutsch gesetzt!!");
                country = Country.Germany.ToString(); 
            }
            
        }
        


        //Strassen Eingabe  
        Console.Write("Straße: ");
        street= Console.ReadLine();

        //Stadt Eingabe 
        Console.Write("Stadt: ");
        city = Console.ReadLine();
    }
    public void Ausgabe()
    {
        //Textfarbe auf Rot umstellen 
        Console.ForegroundColor = ConsoleColor.Red;


        Console.WriteLine($"{ID} ,{customernumber}"); 
        Console.WriteLine(name, zipcode, street, city, country);

       
    }


}