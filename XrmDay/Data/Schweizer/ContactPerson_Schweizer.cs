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
    }
}
