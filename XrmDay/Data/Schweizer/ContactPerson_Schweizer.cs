using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Schweizer
{
    public class ContactPerson_Schweizer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public void einlesen()
        {
            int hilf_while = 0;
            do
            {
                ContactPerson_Schweizer contactPerson_Schweizer = new ContactPerson_Schweizer();

                // ID
                Console.WriteLine("Bitte gib eine Id ein");
                string userInput = Console.ReadLine();

                bool isValid = int.TryParse(userInput, out int parsedID);
                if (isValid)
                {
                    contactPerson_Schweizer.ID = parsedID;
                }

                // Vorname
                Console.WriteLine("Bitte gib einen first name ein");
                userInput = Console.ReadLine();
                contactPerson_Schweizer.FirstName = userInput;

                // Vorname
                Console.WriteLine("Bitte gib einen last name ein");
                userInput = Console.ReadLine();
                contactPerson_Schweizer.LastName = userInput;

                
            } while (hilf_while == 1);
        }
    }
}
