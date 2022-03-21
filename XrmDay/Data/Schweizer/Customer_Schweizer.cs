using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmDay.Data.Schweizer;

namespace XrmDay
{

    public class Customer_Schweizer
    {

        public int ID { get; set; }
        public int? CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Zipcode { get; set; }
        public enumerations.Country Land { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public List<ContactPerson_Schweizer> ContactPersons = new List<ContactPerson_Schweizer>();

    }
}
