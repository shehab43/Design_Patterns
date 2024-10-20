using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Core
{
    public class PayrollCalculator
    {
        public decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculating Salary for employee `{employee.FullName}`");

            if (employee.PayItems?.Any() == false) return 0;

            var monthTotall = employee.PayItems.Sum(payitem => payitem.Value);
            return Math.Round(monthTotall/ DateTime.DaysInMonth(DateTime.Today.Year,DateTime.Today.Month) * DateTime.Today.Day,2);
        }
    }
}
