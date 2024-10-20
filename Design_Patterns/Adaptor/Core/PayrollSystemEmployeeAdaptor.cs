
namespace Design_Patterns.Adaptor.AdaptorPattern.Core
{
    public class PayrollSystemEmployeeAdaptor
    {
        private readonly Employee _employee;
        private readonly List<PayrollSystemPayItemAdaptor> _PayItems;
        public PayrollSystemEmployeeAdaptor(Employee employee)
        {
            _employee = employee;
            _PayItems = employee.PayItems.Select(PayItem => new PayrollSystemPayItemAdaptor(PayItem)).ToList();
        }

        public string FullName => _employee.FullName;

        public IEnumerable<PayrollSystemPayItemAdaptor> PayItems => _PayItems;
    }
}
