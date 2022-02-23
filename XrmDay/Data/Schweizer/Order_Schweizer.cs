using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace XrmDay.Data.Schweizer
{
    public class Order_Schweizer
    {
        public int Id { get; set; }
        public decimal SummaryAmount { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
