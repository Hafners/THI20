using Data.XrmHafners.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.XrmHafners
{
    public class Customer
    {
        #region Properties

        public int Id { get; set; }

        public int CustomerNumber { get; set; }

        public string Name { get; set; }

        public string Zipcode { get; set; }

        public Country Country { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        #endregion
    }
}
