﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core.DiscountStartegies
{
    internal interface ICustomerDiscountStartegy
    {
        double CalculateDiscount(double totalPrice);

    }
}
