using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Verachter
{
    internal class ContactPerson
    {
        #region Properties
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public ContactPerson()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            Birthday = DateTime.MinValue;
            Id = 0;
        }

        #endregion

    }
}
