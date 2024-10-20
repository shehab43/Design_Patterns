using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core
{
    internal class Invoice
    {
        public Customer Customer { get; set; }

        public IEnumerable<InvoiceLine> Lines { get; set; }

        public double DiscountPrecentage {  get; set; }

        public double NetPrice => TotalPrice - (TotalPrice * DiscountPrecentage);
        public double TotalPrice => Lines.Sum(c => c.UnitePrice * c.Quantity);
    }
}
