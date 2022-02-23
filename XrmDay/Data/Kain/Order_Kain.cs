using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

namespace XrmDay.Data.Kain;

public class Order_Kain
{
    public int Id { get; set; }
    public decimal SummaryAmount { get; set; }
    public DateTime OrderDate { get; set; }
    
    public List<OrderPosition_Kain> OrderPositionKainList = new List<OrderPosition_Kain>();
}