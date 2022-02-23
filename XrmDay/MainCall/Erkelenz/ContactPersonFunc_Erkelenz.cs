using System;
using System.Globalization;
using XrmDay.Data.Erkelenz;

namespace XrmDay.MainCall.Erkelenz
{
    public class ContactPersonFunc_Erkelenz
    {
        public void datenEinlesenContactPerson(ContactPerson_Erkelenz contact)
        {
            string ungueltig = "Eingabe ungültig";
            string userInput;

            // id
            Console.Write("Id: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedId)) { contact.Id = parsedId; }
            else { Console.WriteLine(ungueltig); }

            // first name
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            // last name
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            // birthday
            Console.Write("Birthday: ");
            string format = "dd.MM.yyyy";
            DateTime date;
            userInput = Console.ReadLine();
            if (DateTime.TryParseExact(userInput, format, new CultureInfo("de-DE"), DateTimeStyles.None, out date)) { contact.Birthday = date; }
            else { Console.WriteLine(ungueltig); }
        }
        
        public void datenAusgebenContactPerson(ContactPerson_Erkelenz contact)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nId: " + contact.Id);
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.WriteLine("Birthday: " + contact.Birthday.ToString("dd.MM.yyyy"));
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
