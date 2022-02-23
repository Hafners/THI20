using System;
using System.Collections.Generic;
using XrmDay.Data.Kain;

namespace XrmDay.MainCall
{
    public class main_Kain
    {
        List<Customer_Kain> customerList = new List<Customer_Kain>();

        public void addCustomer()
        {
            int temp = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Customer_Kain instance1 = new Customer_Kain();
                Console.WriteLine("|||Customer Method||| ");
                Console.WriteLine("Bitte id eingeben: ");
                string? userInput = Console.ReadLine();

                int parsedID = int.Parse(userInput!);
                bool isValid = int.TryParse(userInput, out int parsedID1);
                if (isValid)
                {
                    instance1.Id = parsedID1;
                }

                Console.WriteLine("Bitte CustomerNumber eingeben: ");
                userInput = Console.ReadLine();

                int parsedCN = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedCN1);
                if (isValid)
                {
                    instance1.CustomerNumber = parsedCN1;
                }

                Console.WriteLine("Bitte Name eingeben: ");
                userInput = Console.ReadLine();
                instance1.Name = userInput!;

                Console.WriteLine("Bitte Postleitzahl eingeben: ");
                userInput = Console.ReadLine();
                instance1.Zipcode = userInput!;

                Console.WriteLine("Bitte Stadt eingeben: ");
                userInput = Console.ReadLine();
                instance1.City = userInput!;

                Console.WriteLine(
                    "Bitte Land auswählen:\n0 = Germany\n1 = England\n2 = Austria\n3 = Brasil\nBei fehlerhafter Angabe: Germany");
                userInput = Console.ReadLine();


                int parsedCT = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedCT1);
                if (isValid)
                {
                    switch (parsedCT1)
                    {
                        case 0:
                            instance1.country = Customer_Kain.Country.Germany;
                            break;
                        case 1:
                            instance1.country = Customer_Kain.Country.England;
                            break;
                        case 2:
                            instance1.country = Customer_Kain.Country.Austria;
                            break;
                        case 4:
                            instance1.country = Customer_Kain.Country.Brasil;
                            break;
                        default:
                            instance1.country = Customer_Kain.Country.Germany;
                            break;
                    }
                }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID: " + instance1.Id);
                Console.WriteLine("CustomerNumber: " + instance1.CustomerNumber);
                Console.WriteLine("Name: " + instance1.Name);
                Console.WriteLine("Postleitzahl: " + instance1.Zipcode);
                Console.WriteLine("Stadt: " + instance1.City);
                Console.WriteLine("Land: " + instance1.country);

                Console.ForegroundColor = ConsoleColor.White;
                instance1.contactpersonList = addContactPerson();
                Console.WriteLine("Weiteren Kunden hinzufügen? [ja = 1 | nein = 0]");

                userInput = Console.ReadLine();
                int parsedS = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedS1);
                if (isValid)
                {
                    temp = parsedS1;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe... Programm wird beendet");
                    temp = 0;
                }

               
                customerList.Add(instance1);
            } while (temp != 0);
        }

        public List<ContactPerson_Kain> addContactPerson()
        {
            List<ContactPerson_Kain> contactPersonKainList = new List<ContactPerson_Kain>();
        
            int temp = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                ContactPerson_Kain instance1 = new ContactPerson_Kain();
                Console.WriteLine("|||ContactPerson Method||| ");
                Console.WriteLine("Bitte ID eingeben: ");
                string? userInput = Console.ReadLine();

                int parsedID = int.Parse(userInput!);
                bool isValid = int.TryParse(userInput, out int parsedID1);
                if (isValid)
                {
                    instance1.Id = parsedID1;
                }

                Console.WriteLine("Bitte Vorname eingeben: ");
                userInput = Console.ReadLine();
                instance1.FirstName = userInput!;

                Console.WriteLine("Bitte Nachname eingeben: ");
                userInput = Console.ReadLine();
                instance1.LastName = userInput!;

                Console.WriteLine("Bitte Geburtstagsdatum eingeben: ");
                userInput = Console.ReadLine();
                DateTime parsedDate = DateTime.Parse(userInput!);
                isValid = DateTime.TryParse(userInput, out DateTime parsedDate1);
                if (isValid)
                {
                    instance1.Birthday = parsedDate1;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID: " + instance1.Id);
                Console.WriteLine("Vorname: " + instance1.FirstName);
                Console.WriteLine("Nachname: " + instance1.LastName);
                Console.WriteLine("Geburtstag: " + instance1.Birthday);
                Console.ForegroundColor = ConsoleColor.White;

                instance1.OrderKainList = addOrder();
                Console.WriteLine("Weitere Kontaktperson hinzufügen? [ja = 1 | nein = 0]");

                userInput = Console.ReadLine();
                int parsedS = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedS1);
                if (isValid)
                {
                    temp = parsedS1;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe... Programm wird beendet");
                    temp = 0;
                }


                contactPersonKainList.Add(instance1);
            } while (temp != 0);

            return contactPersonKainList;
        }

        public List<Order_Kain> addOrder()
        {
            List<Order_Kain> OrderList = new List<Order_Kain>();
            
            int temp = 0;
            do
            {
                Order_Kain instance1 = new Order_Kain();
                Console.WriteLine("|||Order Method||| ");
                Console.WriteLine("Bitte Id eingeben: ");
                string? userInput = Console.ReadLine();
                int parsedID = int.Parse(userInput!);
                bool isValid = int.TryParse(userInput, out int parsedID1);
                if (isValid)
                {
                    instance1.Id = parsedID1;
                }

                Console.WriteLine("Bitte SummaryAmount eingeben: ");
                userInput = Console.ReadLine();
                decimal parsedSA = decimal.Parse(userInput!);
                isValid = decimal.TryParse(userInput, out decimal parsedSA1);
                if (isValid)
                {
                    instance1.SummaryAmount = parsedSA1;
                }

                Console.WriteLine("Bitte Bestelldatum eingeben: ");
                userInput = Console.ReadLine();
                DateTime parsedDate = DateTime.Parse(userInput!);
                isValid = DateTime.TryParse(userInput, out DateTime parsedDate1);
                if (isValid)
                {
                    instance1.OrderDate = parsedDate1;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID: " + instance1.Id);
                Console.WriteLine("SummaryAmount: " + instance1.SummaryAmount);
                Console.WriteLine("OrderDate: " + instance1.OrderDate);
                Console.ForegroundColor = ConsoleColor.White;
                instance1.OrderPositionKainList = addOrderPosition();

                Console.WriteLine("Weitere Order hinzufügen? [ja = 1 | nein = 0]");

                userInput = Console.ReadLine();
                int parsedS = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedS1);
                if (isValid)
                {
                    temp = parsedS1;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe... Programm wird beendet");
                    temp = 0;
                }


                OrderList.Add(instance1);
            } while (temp != 0);

            return OrderList;
        }

        public List<OrderPosition_Kain> addOrderPosition()
        {
            List<OrderPosition_Kain> orderPositionKainList = new List<OrderPosition_Kain>();
            int temp = 0;
            do
            {
                OrderPosition_Kain instance1 = new OrderPosition_Kain();
                Console.WriteLine("|||OrderPosition Method||| ");
                Console.WriteLine("Bitte Id eingeben: ");
                string? userInput = Console.ReadLine();
                int parsedID = int.Parse(userInput!);
                bool isValid = int.TryParse(userInput, out int parsedID1);
                if (isValid)
                {
                    instance1.Id = parsedID1;
                }

                Console.WriteLine("Bitte ArticlenNumber eingeben: ");
                userInput = Console.ReadLine();
                int parsedAN = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedAN1);
                if (isValid)
                {
                    instance1.Articlenumber = parsedAN1;
                }


                Console.WriteLine("Bitte Amount eingeben: ");
                userInput = Console.ReadLine();
                decimal parsedA = decimal.Parse(userInput!);
                isValid = decimal.TryParse(userInput, out decimal parsedA1);
                if (isValid)
                {
                    instance1.Amount = parsedA1;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID: " + instance1.Id);
                Console.WriteLine("ArticleNumber: " + instance1.Articlenumber);
                Console.WriteLine("Amount: " + instance1.Amount);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Weitere Kontaktperson hinzufügen? [ja = 1 | nein = 0]");

                userInput = Console.ReadLine();
                int parsedS = int.Parse(userInput!);
                isValid = int.TryParse(userInput, out int parsedS1);
                if (isValid)
                {
                    temp = parsedS1;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe... Programm wird beendet");
                    temp = 0;
                }
            } while (temp != 0);

            return orderPositionKainList;
        }

        public void execute()
        {
            addCustomer();
        }
    }
}