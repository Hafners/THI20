using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenverwaltung
{
    internal class A_Console
    {
        public void Example()
        {
            // Konsolenausgabe
            Console.WriteLine("Hier könnte Ihre Werbung stehen!");

            // Konsoleneingabe
            string? userInput = Console.ReadLine();

            // Konsole Textfarbe verändern
            Console.ForegroundColor = ConsoleColor.Red;

            // Konsole Hintergrundfarbe verändern
            Console.BackgroundColor = ConsoleColor.Red;

            // Konsole warten auf irgendeine Eingabe
            Console.ReadKey();
        }
    }
}