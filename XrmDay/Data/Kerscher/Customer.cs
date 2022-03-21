using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Kerscher
{
    internal class Customer
    {
        public
        int ID;
        public
        int customernumber;
        public
        string name;
        public
        string zipcode;
        public
        enum Country
        {
            Germany = 0,
            England = 1,
            Austria = 2,
            Brasil = 3
        }
        public
        string street;
        public
        string city;
        public 
        string country;
        
            
    }
}
