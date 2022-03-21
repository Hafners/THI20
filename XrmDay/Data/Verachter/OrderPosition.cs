using System;
using System.Collections.Generic;
using System.Text;

namespace XrmDay.Data.Verachter
{
    public class OrderPosition
    {
        #region Properties
        public int Id { get; set; }
        public int ArticleNumber { get; set; }
        public decimal Amount { get; set; }

        public OrderPosition()
        {
            Id = 0;
            ArticleNumber = 0;
            Amount = 0;
        }
        #endregion
    }
}
