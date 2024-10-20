using Design_Patterns.StrategyPattern.core;
using Design_Patterns.StrategyPattern.core.DiscountStartegies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    internal class Strategy
    {
        public static void stratgyToRun()
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();

            while (true)
            {
                Console.WriteLine("customer list :  [1] shehab Mohamed Fathy [2] Ahmed Fathy ");

                Console.Write($"Enter Cusomer Id :");
                var CustomerId = int.Parse(Console.ReadLine());

                Console.Write($"Enter Item Quantity :");
                var quantity = double.Parse(Console.ReadLine());


                Console.Write($"Enter Unity Price:");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.First(c => c.Id == CustomerId);
                ICustomerDiscountStartegy customerDiscountStartegy = null;
                if (customer.Category == CustomerCategory.Silver)
                    customerDiscountStartegy = new SilverCustomerDiscountStartegy();
                else if (customer.Category == CustomerCategory.Gold)
                    customerDiscountStartegy = new GoldCustomerDiscountStartegy();

                
                var invoiceManger =new InvoiceManger();
                invoiceManger.SetDiscountStartegy(customerDiscountStartegy);
                var invoice = invoiceManger.CreateInvoice(customer , quantity, unitPrice);
                //Console.WriteLine($"Invoice Created for customer`{customer.Name}`with total price :{invoice.TotalPrice} ");
                Console.WriteLine($"Invoice Created for customer`{customer.Name}`with net price :{invoice.NetPrice} ");

            } 
        }
    }
}
