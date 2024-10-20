using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern.core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,

                    Name = "shehab Mohamed Fathy",

                    Category = CustomerCategory.Gold


                },
                new Customer
                {
                    Id = 2,

                    Name = "Ahmed Fathy",
                   Category = CustomerCategory.Silver


                }
            };

        }
    }
}
