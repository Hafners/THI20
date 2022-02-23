using System.Collections.Generic;

namespace XrmDay.Data.Kain
{
    public class Customer_Kain
    {
        public int Id { get; set; }
        public int CustomerNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public Country country { get; set; } = Country.Germany;

        public enum Country
        {
            Germany,
            England,
            Austria,
            Brasil
        }
        
        public List<ContactPerson_Kain> contactpersonList { get; set; } = new List<ContactPerson_Kain>(); 
    }
}