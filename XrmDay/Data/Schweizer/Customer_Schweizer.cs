using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrmDay
{

    public class Customer_Schweizer
    {

        public int ID { get; set; }
        public int? CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Zipcode { get; set; }
        public Data.Schweizer.enumerations.Country Land { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
