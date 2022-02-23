using System;
using System.Collections.Generic;

namespace XrmDay.Data.Erkelenz
{
    public class Order_Erkelenz
    {
        public int Id { get; set; }
        public decimal SummaryAmount { get; set; } = 0;
        public DateTime OrderDate { get; set; }
        public List<OrderPosition_Erkelenz> OrderPositions { get; set; }
    }
}
