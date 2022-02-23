using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using XrmDay.Data.Erkelenz;

namespace XrmDay.MainCall.Erkelenz
{
    public class OrderFunc_Erkelenz
    {
        OrderPositionFunc_Erkelenz orderPositionFunc = new OrderPositionFunc_Erkelenz();
        public void DatenEinlesen(Order_Erkelenz order)
        {
            string ungueltig = "Eingabe ungültig";
            string userInput;

            // id 
            Console.Write("Id: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedId)) { order.Id = parsedId; }
            else { Console.WriteLine(ungueltig); }

            // orderDate
            Console.Write("Date of Order (dd.mm.yyyy): ");
            string format = "dd.MM.yyyy";
            userInput = Console.ReadLine();
            if (DateTime.TryParseExact(userInput, format, new CultureInfo("de-DE"), DateTimeStyles.None, out DateTime parsedDate)) { order.OrderDate = parsedDate; }
            else { Console.WriteLine(ungueltig); }

            // orderPositions
            order.OrderPositions = new List<OrderPosition_Erkelenz>();
            int count = 0;
            string inputOrderPos = Console.ReadLine();
            while (inputOrderPos != "Exit")
            {
                OrderPosition_Erkelenz orderPosition = new OrderPosition_Erkelenz();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("--------\nOrder Position " + ++count + ": ");
                orderPositionFunc.DatenEinlesen(orderPosition);
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.White;
                order.OrderPositions.Add(orderPosition);
                inputOrderPos = Console.ReadLine();
            }
            CalcSummaryAmount(order);
        }

        public void DatenAusgeben(Order_Erkelenz order)
        {
            Console.WriteLine("Id: " + order.Id);
            Console.WriteLine("Summary Amount: " + order.SummaryAmount);
            Console.WriteLine("Date of Order: " + order.OrderDate.ToString("dd.MM.yyyy"));
            int count = 0;
            foreach (OrderPosition_Erkelenz orderPosition in order.OrderPositions)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Order Position " + ++count + ": ");
                orderPositionFunc.DatenAusgeben(orderPosition);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void CalcSummaryAmount(Order_Erkelenz order)
        {
            foreach (OrderPosition_Erkelenz orderPosition in order.OrderPositions)
            {
                order.SummaryAmount += orderPosition.Amount;
            }
        }
    }
}