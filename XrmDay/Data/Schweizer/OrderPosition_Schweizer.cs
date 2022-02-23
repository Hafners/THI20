using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace XrmDay.Data.Schweizer
{
    public class OrderPosition_Schweizer
    {
        public int Id { get; set; }
        public int ArticleNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
