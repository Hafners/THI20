using Data;
using System;
using Data.XrmRose;
using Data.XrmRose.Enumerations;

namespace Kundenverwaltung
{
    class Program
    {
        public void Abfrage()
        { 
            #region Benutzerabfrage
            Console.WriteLine("ID: ");
            string? customerID = Console.ReadLine();

            Console.WriteLine("CustomerNumber: ");
            string? customerNumber = Console.ReadLine();

            Console.WriteLine("Name: ");
            string? customerName = Console.ReadLine();

            Console.WriteLine("Zipcode: ");
            string? customerZipcode = Console.ReadLine();

            Console.WriteLine("Country (Germany, England, Austria, Brazil): ");
            string? customerCountry = Console.ReadLine();

            Console.WriteLine("Street: ");
            string? customerStreet = Console.ReadLine();

            Console.WriteLine("City: ");
            string? customerCity = Console.ReadLine();
            #endregion

            #region inDieKlasse
            Customer_Rose customer1 = new Customer_Rose();
            bool isValid1 = int.TryParse(customerID, out int intID);
            if(isValid1)
            {
                customer1.Id = intID;
            }
            bool isValid2 = int.TryParse(customerNumber, out int intNr);
            if (isValid2)
            {
                customer1.CustomerNumber = intNr;
            }
           
            bool isValid3 = Enum.TryParse(customerCountry, out Country EnumCountry);
            if(isValid3)
            {
                customer1.Country = EnumCountry;
            }


