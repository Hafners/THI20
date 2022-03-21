using XrmDay.Data.Kerscher; 
using System;
using System.Collections.Generic;
using static XrmDay.Data.Kerscher.Customer;
using static XrmDay.Data.Kerscher.ContactPerson;

namespace XrmDay.MainCall
{
    internal class main_kerscher
    {
        List<Customer> list = new List<Customer>();
        List<ContactPerson> listContact = new List<ContactPerson>();
        List<Order> listOrder = new List<Order>();
        List<OrderPosition> listPosition = new List<OrderPosition>();

        public void execute()
        {
            string abbruch;
            string abbruch2;

            //Kundenbearbeitung Aufgabe 1
            do
            {
                Customer customer = Eingabe();

                list.Add(customer);

                Console.WriteLine("Weiter laufen ? , wenn nein dann exit!!");
                abbruch = Console.ReadLine();
            } while (abbruch != "exit");

            Console.WriteLine("Jetzt die Kontaktpersonen: ");

            //Kontaktpersonenbearbeitung Aufgabe 2
            do
            {
                ContactPerson person = Kontaktperson();

                listContact.Add(person);

                Console.WriteLine("Weiter laufen ? , wenn nein dann exit!");
                abbruch2 = Console.ReadLine();
            } while (abbruch2 != "exit");

            //Orderbearbeitung Aufgabe 3
            do
            {

                Order bestellung = Eingabeorder();





                listOrder.Add(bestellung);

                Console.WriteLine("Weiter laufen ? , wenn nein dann exit!!");
                abbruch = Console.ReadLine();
            } while (abbruch != "exit");


            //OrderPositionbearbeitung Aufgabe 3
            do
            {
                OrderPosition position = EingabePosition();




                listPosition.Add(position);

                Console.WriteLine("Weiter laufen ? , wenn nein dann exit!!");
                abbruch = Console.ReadLine();
            } while (abbruch != "exit");



            Ausgabe();
            Ausgabeperson();
            AusgabeOrder();
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
            foreach (Customer customer1 in list)
            {
                Console.WriteLine("Kunde: ");
                //Textfarbe auf Rot umstellen 
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"ID: {customer1.ID} \n CustomerNummer: {customer1.customernumber}");
                Console.WriteLine($"CustomerName: {customer1.name} \n Customer-Zipcode: {customer1.zipcode} \n CustomerStraße: {customer1.street} \n Customerstadt: {customer1.city} \n CustomerLand: {customer1.country} \n");
            }



        }
        public ContactPerson Kontaktperson()
        {
            ContactPerson person = new ContactPerson();

            //Vorname Kontaktperson: 
            Console.Write("VorName: ");
            person.firstname = Console.ReadLine();

            //Nachname Kontaktperson: 
            Console.Write("NachName: ");
            person.lastname = Console.ReadLine();

            //ID-Eingabe 
            Console.Write("ID: ");
            string? contactID = Console.ReadLine();
            if (int.TryParse(contactID, out int idcontact))
            {
                person.ID = idcontact;
            }
            //Geb-Datum Eingabe
            Console.Write("GebDat: ");
            string? geb = Console.ReadLine();
            if (DateTime.TryParse(geb, out DateTime gebdat))
            {
                person.birthday = gebdat;
            }
            return person;

        }
        public void Ausgabeperson()
        {
            Console.WriteLine("Kontaktperson:");
            foreach (ContactPerson person in listContact)
            {
                //Textfarbe auf Rot umstellen 
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"ID: {person.ID} \n Vorname: {person.firstname} \n Nachname: {person.lastname} \n Geburtsdatum: {person.birthday}");

            }
        }
        public Order Eingabeorder()
        {
            Order bestellung = new Order();

            //Abfrage der ID
            Console.Write("ID: ");
            string? orderID = Console.ReadLine();
            if (int.TryParse(orderID, out int idorder))
            {
                bestellung.ID = idorder;
            }

            //Eingabe der Summary Amount
            Console.Write("Summary Amóunt: ");
            string? amountID = Console.ReadLine();
            if (decimal.TryParse(amountID, out decimal IDamount))
            {
                bestellung.SummaryAmmount = IDamount;
            }

            //Eingabe von DateTime(OrderDate)
            Console.Write("ID: ");
            string? dati = Console.ReadLine();
            if (DateTime.TryParse(dati, out DateTime datidate))
            {
                bestellung.OrderDate = datidate; ;
            }
            return bestellung;
        }
        public OrderPosition EingabePosition()
        {
            OrderPosition posi = new OrderPosition();

            //Abfrage der ID
            Console.Write("ID: ");
            string? posiID = Console.ReadLine();
            if (int.TryParse(posiID, out int idposi))
            {
                posi.ID = idposi;
            }
            //Abfrage der Artikelnummer
            Console.Write("Artikelnummer");
            string? nummerArtikel = Console.ReadLine();
            if (int.TryParse(nummerArtikel, out int artnummer))
            {
                posi.ArticleNumber = artnummer;
            }

            //Abfrage der Decimal Amount 
            Console.Write("Dezimal Amount: ");
            string? amdez = Console.ReadLine();
            if (decimal.TryParse(amdez, out decimal dez))
            {
                posi.Amount = dez;
            }

            return posi;


        }

        public void AusgabeOrder()
        {
            Console.WriteLine("OrderInfos:");
            foreach (Order od in listOrder)
            {
                //Textfarbe auf Rot umstellen 
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine($"ID: {od.ID} \n Sumary Amount: {od.SummaryAmmount} \n OrderDate: {od.OrderDate} \n");

            }
            foreach (OrderPosition op in listPosition)
            {
                //Textfarbe auf Rot umstellen 
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"ID: {op.ID} \n ArtikelNummer: {op.ArticleNumber } \n Amount: {op.Amount} \n");
            }
        }
    }
}
