using Design_Patterns.StrategyPattern.core.DiscountStartegies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core
{
    internal class InvoiceManger
    {
        private ICustomerDiscountStartegy _customerDiscountStartegy;
        public void SetDiscountStartegy(ICustomerDiscountStartegy startegy) 
        {
            _customerDiscountStartegy = startegy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                  {
                     new InvoiceLine {Quantity = quantity, UnitePrice =  unitPrice}
                  },

            };
            invoice.DiscountPrecentage = _customerDiscountStartegy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
