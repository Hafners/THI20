using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace XrmDay.MainCall
{
    internal class main_schweizer
    {
        public void Execute()
        {
            int weiter = 0;
            List<Customer_Schweizer> customerList = new List<Customer_Schweizer>();
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Customer_Schweizer customer = new Customer_Schweizer();

                Console.WriteLine("Customer eingeben");

                // ID
                Console.WriteLine(" Bitte gib eine Customer-ID ein");
                string userInput = Console.ReadLine();

                bool isValid = int.TryParse(userInput, out int parsedID);
                if (isValid)
                {
                    customer.ID = parsedID;
                }
                else { customer.ID = 0; }

                // CustomerNummer
                Console.WriteLine(" Bitte gib eine Customer-Number ein");
                userInput = Console.ReadLine();

                isValid = int.TryParse(userInput, out int parsedCustNum);
                if (isValid)
                {
                    customer.CustomerNumber = parsedCustNum;
                }
                else { customer.CustomerNumber = 0; }

                // Name
                Console.WriteLine(" Bitte gib einen Customer-Name ein");
                userInput = Console.ReadLine();
                customer.Name = userInput;

                // Zipcode
                Console.WriteLine(" Bitte gib einen Customer-Zipcode ein");
                userInput = Console.ReadLine();
                customer.Zipcode = userInput;

                // Country 
                Console.WriteLine(" Bitte gib ein Customer-Country ein (Germany=0, England=1, Austria=2, Brasil=3)");
                userInput = Console.ReadLine();

                isValid = enumerations.Country.TryParse(userInput, out enumerations.Country parsedCountry);
                if (isValid)
                {
                    switch (parsedCountry)
                    {
                        case (Data.Schweizer.enumerations.Country)0:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)1:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)2:
                            customer.Land = parsedCountry;
                            break;
                        case (Data.Schweizer.enumerations.Country)3:
                            customer.Land = parsedCountry;
                            break;
                    }
                }

                // Street
                Console.WriteLine(" Bitte gib eine Customer-Street ein");
                userInput = Console.ReadLine();
                customer.Street = userInput;

                // City
                Console.WriteLine(" Bitte gib eine Customer-City ein");
                userInput = Console.ReadLine();
                customer.City = userInput;

                // Konsole Textfarbe verändern
                Console.ForegroundColor = ConsoleColor.White;

                execute_ContactPerson(customer);

                // Ausgabe Customer
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------CUSTOMER-----------");
                Console.WriteLine("ID: " + customer.ID);
                Console.WriteLine("CustomerNumber: " + customer.CustomerNumber);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Zipcode: " + customer.Zipcode);
                Console.WriteLine("Country: " + customer.Land);
                Console.WriteLine("Street: " + customer.Street);
                Console.WriteLine("City: " + customer.City);

                // Ausgabe ContactPersons
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------ContactPerson----------");
                customer.ContactPersons.ForEach(contactPerson =>
                {
                    Console.WriteLine(
                    "  ID: " + contactPerson.ID +
                    "  First Name: " + contactPerson.FirstName +
                    "  Last Name: " + contactPerson.LastName +
                    "  Birthday: " + contactPerson.Birthday);

                    // Ausgabe Order
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("------------Order-----------");
                    contactPerson.order_Schweizers.ForEach(orderSchweizer =>
                    {
                        Console.WriteLine(
                            "       ID: " + orderSchweizer.Id +
                            "       SummaryAmount: " + orderSchweizer.SummaryAmount +
                            "       OrderDate: " + orderSchweizer.OrderDate);
                    });

                    // Ausgabe OrderPosition
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------OrderPosition--------");

                    contactPerson.orderPosition_Schweizers.ForEach(positionSchweizer =>
                    {
                        Console.WriteLine(
                            "       ID: " + positionSchweizer.Id +
                            "       ArticleNumber: " + positionSchweizer.ArticleNumber +
                            "       Amount: " + positionSchweizer.Amount);
                    });
                    Console.ForegroundColor = ConsoleColor.Green;

                });


                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Customer eingeben (1=ja, 0=nein): ?");
                userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out int parsedDO);

                customerList.Add(customer);

                weiter = 0;
                if (isValid && parsedDO == 1)
                {
                    weiter = 1;
                }
            } while (weiter == 1);
        }

        public void execute_ContactPerson(Customer_Schweizer customer_Schweizer)
        {
            int hilf_while = 0;
            Console.WriteLine(" ContactPerson eingeben (1=ja, 0=nein): ?");
            string userInput = Console.ReadLine();
            bool isValid = int.TryParse(userInput, out int parsedJA);

            if (isValid && parsedJA == 1)
            {
                do
                {
                    ContactPerson_Schweizer contactPerson_Schweizer = new ContactPerson_Schweizer();

                    // ID
                    Console.WriteLine("     Bitte gib eine ContactPerson-ID ein");
                    userInput = Console.ReadLine();

                    isValid = int.TryParse(userInput, out int parsedID);
                    if (isValid)
                    {
                        contactPerson_Schweizer.ID = parsedID;
                    }
                    else { contactPerson_Schweizer.ID = 0; }

                    // Vorname
                    Console.WriteLine("     Bitte gib einen ContactPerson-FirstName ein");
                    userInput = Console.ReadLine();
                    contactPerson_Schweizer.FirstName = userInput;

                    // Vorname
                    Console.WriteLine("     Bitte gib einen ContactPerson-LastName ein");
                    userInput = Console.ReadLine();
                    contactPerson_Schweizer.LastName = userInput;

                    // Birthday
                    Console.WriteLine("     Bitte gib einen ContactPerson-Birtday ein");
                    userInput = Console.ReadLine();

                    isValid = DateTime.TryParse(userInput, out DateTime parsedBirthday);
                    if (isValid)
                    {
                        contactPerson_Schweizer.Birthday = parsedBirthday;
                    }
                    else
                    {
                        contactPerson_Schweizer.Birthday = DateTime.MinValue;
                    }

                    execute_OrderSchweizer(contactPerson_Schweizer);
                    execute_OrderPositionSchweizer(contactPerson_Schweizer);
                    customer_Schweizer.ContactPersons.Add(contactPerson_Schweizer);


                    Console.WriteLine(" ContactPerson eingeben (1=ja, 0=nein): ?");
                    userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out int parsedDO);

                    hilf_while = 0;
                    if (isValid && parsedDO == 1)
                    {
                        hilf_while = 1;
                    }

                } while (hilf_while == 1);
            }
        }

        public void execute_OrderSchweizer(ContactPerson_Schweizer contactPerson_Schweizer)
        {
            int weiter = 0;
            Console.WriteLine("     Order eingeben (1=ja, 0=nein): ?");
            string userInput = Console.ReadLine();
            bool isValid = int.TryParse(userInput, out int parsedJA);
            if (isValid && parsedJA == 1)
            {
                do
                {
                    Order_Schweizer order_Schweizer = new Order_Schweizer();
                    // ID
                    Console.WriteLine("         Bitte gib eine Id ein");
                    userInput = Console.ReadLine();

                    isValid = int.TryParse(userInput, out int parsedID);
                    if (isValid)
                    {
                        order_Schweizer.Id = parsedID;
                    }
                    else { order_Schweizer.Id = 0; }

                    // SummaryAmount
                    Console.WriteLine("         Bitte gib einen SummaryAmount ein");
                    userInput = Console.ReadLine();

                    isValid = decimal.TryParse(userInput, out decimal parsedSummaryAmount);
                    if (isValid)
                    {
                        order_Schweizer.SummaryAmount = parsedSummaryAmount;
                    }
                    else { order_Schweizer.SummaryAmount = 0; }

                    // OrderDate
                    Console.WriteLine("         Bitte gib ein OrderDate ein");
                    userInput = Console.ReadLine();

                    isValid = DateTime.TryParse(userInput, out DateTime parsedOrderDate);
                    if (isValid)
                    {
                        order_Schweizer.OrderDate = parsedOrderDate;
                    }
                    else { order_Schweizer.OrderDate = DateTime.MinValue; }

                    contactPerson_Schweizer.order_Schweizers.Add(order_Schweizer);

                    // Nochmal?
                    Console.WriteLine("     Order eingeben (1=ja, 0=nein): ?");
                    userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out int parsedDO);

                    weiter = 0;
                    if (isValid && parsedDO == 1)
                    {
                        weiter = 1;
                    }
                } while (weiter == 1);
            }
        }

        public void execute_OrderPositionSchweizer(ContactPerson_Schweizer contactPerson_Schweizer)
        {
            int weiter = 0;
            Console.WriteLine("     OrderPosition eingeben (1=ja, 0=nein): ?");
            string userInput = Console.ReadLine();
            bool isValid = int.TryParse(userInput, out int parsedJA);
            if (isValid && parsedJA == 1)
            {
                do
                {
                    OrderPosition_Schweizer orderPostion_Schweizer = new OrderPosition_Schweizer();
                    // ID
                    Console.WriteLine("         Bitte gib eine Id ein");
                    userInput = Console.ReadLine();

                    isValid = int.TryParse(userInput, out int parsedID);
                    if (isValid)
                    {
                        orderPostion_Schweizer.Id = parsedID;
                    }
                    else { orderPostion_Schweizer.Id = 0; }

                    // Amount
                    Console.WriteLine("         Bitte gib einen Amount ein");
                    userInput = Console.ReadLine();

                    isValid = decimal.TryParse(userInput, out decimal parsedAmount);
                    if (isValid)
                    {
                        orderPostion_Schweizer.Amount = parsedAmount;
                    }
                    else { orderPostion_Schweizer.Amount = 0; }

                    // ArticleNumber
                    Console.WriteLine("         Bitte gib eine ArticleNumber ein");
                    userInput = Console.ReadLine();

                    isValid = int.TryParse(userInput, out int parsedArticleNumber);
                    if (isValid)
                    {
                        orderPostion_Schweizer.ArticleNumber = parsedArticleNumber;
                    }
                    else { orderPostion_Schweizer.ArticleNumber = 0; }

                    contactPerson_Schweizer.orderPosition_Schweizers.Add(orderPostion_Schweizer);

                    // Nochmal?
                    Console.WriteLine("     OrderPosition eingeben (1=ja, 0=nein): ?");
                    userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out int parsedDO);


                    weiter = 0;
                    if (isValid && parsedDO == 1)
                    {
                        weiter = 1;
                    }
                } while (weiter == 1);
            }
        }

    }   
}
