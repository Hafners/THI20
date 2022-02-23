using System;
using System.Collections.Generic;
using System.Text;
using XrmDay.Data.Schweizer;

namespace xrmday.data.schweizer
{
    public class orderposition_schweizer
    {
        public int Id { get; set; }
        public int articlenumber { get; set; }
        public decimal amount { get; set; }
    }
}
