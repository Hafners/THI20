using XrmDay.Data.Kerscher; 
using System;
using System.Collections.Generic;
using static XrmDay.Data.Kerscher.Customer;

namespace XrmDay.MainCall
{
    internal class main_kerscher
    {
            List<Customer> list = new List<Customer>();
      
        public void execute()
        {
            string abbruch;
            
            do
            {
                Customer customer = Eingabe();

                list.Add(customer);

                Console.WriteLine("Weiter laufen ? , wenn nein dann exit!!");
                abbruch = Console.ReadLine();
            } while (abbruch != "exit");

            Ausgabe();
        }

        public Customer Eingabe()
        {
            Customer customer1 = new Customer();

            //ID-Eingabe 
            Console.Write("ID: ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedId))
            {
                customer1.ID = parsedId;
            }
            else { Console.WriteLine("Eingabe ungültig!"); }


            //Customer-Nummer-Eingabe
            Console.Write("CustomerNummer: ");
            string? Customer = Console.ReadLine();
            if (int.TryParse(Customer, out int customersID))
            {
                customer1.customernumber = customersID;
            }
            else
            {
                Console.WriteLine("Bitte gültiges Format für die Kundennummer eingeben!");
            }

            //Kundename Eingabe 
            Console.Write("Name: ");
           customer1.name = Console.ReadLine();

            //zipcode
            Console.Write("Zipcode: ");
            customer1.zipcode = Console.ReadLine();

            //ENUM-Eingabe 
            Console.Write("Germany = 0");
            Console.Write("England = 1");
            Console.Write("Austria = 2");
            Console.Write("Brasil = 3");

            string? userlanguage = Console.ReadLine();

            if (int.TryParse(userlanguage, out int CountryId))
            {
                if (CountryId == 0)
                {
                    customer1.country = Country.Germany.ToString();
                }
                else if (CountryId == 1)
                {
                    customer1.country = Country.England.ToString();
                }
                else if (CountryId == 2)
                {
                    customer1.country = Country.Austria.ToString();
                }
                else if (CountryId == 4)
                {
                    customer1.country = Country.Brasil.ToString();
                }
                else
                {
                    Console.Write("Ungültige Eingabe. Default wird auf Deutsch gesetzt!!");
                    customer1.country = Country.Germany.ToString();
                }

            }



            //Strassen Eingabe  
            Console.Write("Straße: ");
            customer1.street = Console.ReadLine();

            //Stadt Eingabe 
            Console.Write("Stadt: ");
            customer1.city = Console.ReadLine();

            return customer1; 
        }

        public void Ausgabe()
        {
            foreach(Customer customer1 in list)
            {
                //Textfarbe auf Rot umstellen 
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"ID: {customer1.ID} \n CustomerNummer: {customer1.customernumber}");
                Console.WriteLine($"CustomerName: {customer1.name} \n Customer-Zipcode: {customer1.zipcode} \n CustomerStraße: {customer1.street} \n Customerstadt: {customer1.city} \n CustomerLand: {customer1.country} \n");
            }
            


        }
    }
}
