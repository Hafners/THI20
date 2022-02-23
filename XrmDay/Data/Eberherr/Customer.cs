namespace XrmDay.Data.Eberherr
{
    using System;
    using System.Collections.Generic;
    using System.Text;

        class Customer
        {

            private int Id;
            private int CustomerNumber;
            private string Zipcode = string.Empty;
            private string Street = string.Empty;
            private string City = string.Empty;
            private string Country = string.Empty;

            public void einlesen(Customer Customer)
            {
                // Id:
                Console.WriteLine("Id: ");
                string? userInput = Console.ReadLine();

                int parsedInput = int.Parse(userInput);
                bool isValid = int.TryParse(userInput, out int parsedInput1);
                if (isValid)
                {
                    Customer.Id = parsedInput1;
                }

                // CustomerNumber:
                Console.WriteLine("CustomerNumber: ");
                userInput = Console.ReadLine();

                parsedInput = int.Parse(userInput);
                isValid = int.TryParse(userInput, out parsedInput1);
                if (isValid)
                {
                    Customer.CustomerNumber = parsedInput1;
                }

                // Zipcode:
                Console.WriteLine("Zipcode: ");
                Customer.Zipcode = Console.ReadLine();

                // Street:
                Console.WriteLine("Street: ");
                Customer.Street = Console.ReadLine();

                // City:
                Console.WriteLine("City: ");
                Customer.City = Console.ReadLine();

                // Country:
                Console.WriteLine("Country: ");
                Customer.Country = Console.ReadLine();
            }
        }
}
