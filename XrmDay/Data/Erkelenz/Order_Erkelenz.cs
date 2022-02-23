using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Erkelenz
{
    public class Order_Erkelenz
    {
        public int Id { get; set; }
        public decimal SummaryAmount { get; set; }  
        public DateTime OrderDate { get; set; }
    }
}
