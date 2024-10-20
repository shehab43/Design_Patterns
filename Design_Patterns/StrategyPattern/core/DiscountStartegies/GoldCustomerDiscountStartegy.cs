using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core.DiscountStartegies
{
    internal class GoldCustomerDiscountStartegy : ICustomerDiscountStartegy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.1 : 0;
        }
    
    }
}
