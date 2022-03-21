using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Verachter
{
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public decimal SummaryAmount { get; set; }
        public DateTime OrderDate { get; set; }
        
        public Order()
        {
            Id = 0;
            SummaryAmount = 0;
            OrderDate = DateTime.MinValue;
        }

        public List<OrderPosition> orderPositions = new List<OrderPosition>();
        #endregion
    }
}
