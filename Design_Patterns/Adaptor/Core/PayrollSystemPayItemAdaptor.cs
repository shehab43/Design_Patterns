
//namespace Design_Patterns.Adaptor.AdaptorPattern.Core
//{
//    public class PayrollSystemPayItemAdaptor
//    {
//        private readonly PayItem _payItem;
//        public PayrollSystemPayItemAdaptor(PayItem  payItem)
//        {
//            _payItem = payItem;

//        }
//        public string Name => _payItem.Name;
//        public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 :_payItem.Value ;
//    }
//}
using Design_Patterns.Adaptor.AdaptorPattern.Core;

public class PayrollSystemPayItemAdaptor
{
    private readonly PayItem _payItem;

    public PayrollSystemPayItemAdaptor(PayItem payItem)
    {
        _payItem = payItem;
    }

    // The Name of the pay item (e.g., "Bonus", "Tax")
    public string Name => _payItem.Name;

    // Adjust the value based on whether it's a deduction (negative) or not
    public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;
}
