using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core.DiscountStartegies
{
    internal class NewCustomerDiscountStartegy : ICustomerDiscountStartegy

    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
