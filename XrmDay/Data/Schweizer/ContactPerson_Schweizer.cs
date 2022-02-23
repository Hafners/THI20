using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace XrmDay.Data.Schweizer
{   
    public class ContactPerson_Schweizer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public List<Order_Schweizer> order_Schweizers = new List<Order_Schweizer>();

       // public List<OrderPosition_Schweizer> orderPosition_Schweizers = new List<OrderPosition_Schweizer>();
    }
}
