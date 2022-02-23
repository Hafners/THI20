using System.Collections.Generic;
using XrmDay.Data.Erkelenz.Enumerations;

namespace XrmDay.Data.Erkelenz
{
    public class Customer_Erkelenz
    {
        #region Properties
        public int Id { get; set; }
        public int CustomerNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public Country_Erkelenz Country { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public List<ContactPerson_Erkelenz> ContactPersons { get; set; }
        #endregion
    }
}
