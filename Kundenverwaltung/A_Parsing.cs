using Data;
using System;

namespace Kundenverwaltung
{


    class A_Parsing
    {
        public void Example()
        {
            Kunde_Hafner instance1 = new Kunde_Hafner();

            Console.WriteLine("Bitte gib dein alter ein");
            string? userInput = Console.ReadLine();

            int parsedAge = int.Parse(userInput);
            bool isValid = int.TryParse(userInput, out int parsedAge1);
            if (isValid)
            {
                instance1.Age = parsedAge1;
            }
        }
    }
}
