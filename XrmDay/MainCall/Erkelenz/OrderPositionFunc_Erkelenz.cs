using System;
using XrmDay.Data.Erkelenz;

namespace XrmDay.MainCall.Erkelenz
{
    public class OrderPositionFunc_Erkelenz
    {
        public void datenEinlesen(OrderPosition_Erkelenz orderPosition)
        {
            string ungueltig = "Eingabe ungültig";
            string userInput = string.Empty;

            // id 
            Console.Write("Id: ");
            userInput = Console.ReadLine();
            if(int.TryParse(userInput, out int parsedId)) { orderPosition.Id = parsedId; }
            else { Console.WriteLine(ungueltig); }

            // article nr
            Console.Write("Article Number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedArtNr)) { orderPosition.ArticleNumber = parsedArtNr; }
            else { Console.WriteLine(ungueltig); }

            // amount
            Console.Write("Amount: ");
            userInput= Console.ReadLine();
            if(decimal.TryParse(userInput, out decimal parsedAmount)) { orderPosition.Amount = parsedAmount; }
            else { Console.WriteLine(ungueltig); }
        }
        public void datenAusgeben(OrderPosition_Erkelenz orderPosition)
        {
            Console.WriteLine("Id: " + orderPosition.Id);
            Console.WriteLine("Article Number: " +  orderPosition.ArticleNumber);
            Console.WriteLine("Amount: " + orderPosition.Amount);
        }
    }
}
