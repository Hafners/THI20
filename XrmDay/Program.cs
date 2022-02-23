using XrmDay.MainCall;
using System;
using XrmDay.Data;
using System.Xml;
using XrmDay.Data.Erkelenz;

namespace XrmDay
{
}
class Program
{

    static void Main(string[] args)
    {
        //new Main_Erkelenz().Execute();
     
        /* Logic: 
         *  - check if file exists
         *      if yes -> append
         *      else -> create
         */

        Customer_Erkelenz customer = new Customer_Erkelenz();
        customer.Name = "Nina";
        customer.Id = 1;

        XmlTextWriter textWriter = new XmlTextWriter("..\\..\\..\\Data\\Erkelenz\\Files\\data.xml", null);
        textWriter.WriteStartDocument();
        textWriter.WriteStartElement("customer");
        textWriter.WriteStartAttribute("id");
        textWriter.WriteValue("3");
        textWriter.WriteEndAttribute();
        textWriter.WriteEndElement();
        textWriter.WriteEndDocument();
        textWriter.Close();
    }
}
