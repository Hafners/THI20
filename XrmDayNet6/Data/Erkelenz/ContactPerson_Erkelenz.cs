using System;
using System.Collections.Generic;

namespace XrmDay.Data.Erkelenz
{
    public class ContactPerson_Erkelenz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public List<Order_Erkelenz> Orders { get; set; }
    }
}
