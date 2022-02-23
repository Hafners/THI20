using XrmDay.MainCall;
using System;
using XrmDay.Data;
using System.Xml;
using XrmDay.Data.Erkelenz;
using System.Collections.Generic;

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

        List<Customer_Erkelenz> list = new List<Customer_Erkelenz> { 
            new Customer_Erkelenz(),

        }
        Customer_Erkelenz customer = new Customer_Erkelenz();
        customer.Name = "Nina";
        customer.Id = 1;

        var customerlist = utility.GetCustomerList();
        var xmlfromLINQ = new XElement("customers",
                    from c in customerlist
                    select new XElement("customer",
                        new XElement("CustomerId", c.CustomerId),
                        new XElement("CustomerName", c.CustomerName),
                        new XElement("PhoneNumber", c.PhoneNumber),
                        new XElement("Email", c.Email)
                        ));

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
