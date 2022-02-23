using System;
using System.Collections.Generic;

namespace XrmDay.Data.Kain;

public class ContactPerson_Kain
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public DateTime Birthday { get; set; }
    
    public List<Order_Kain> OrderKainList = new List<Order_Kain>();
    
}