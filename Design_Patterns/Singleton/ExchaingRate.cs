using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class ExchaingRate
    {
        
        public ExchaingRate(string baseCurrency,string targetCurrency , decimal rate)
        {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
        public string BaseCurrency { get;  }
        public string TargetCurrency { get;  }
        public decimal Rate { get;  }
    }
}
