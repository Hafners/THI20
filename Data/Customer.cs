using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        enum Country { Germany, England, Austria, Brazil }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
