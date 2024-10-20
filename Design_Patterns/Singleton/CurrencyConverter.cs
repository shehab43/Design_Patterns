using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchaingRate> _exchaingRates;

        //1- private ctr of obj to prevent create new instance out of the class
        private CurrencyConverter()
        {
            loadExchangeRates();
        }
        // Lock to prevent multible thread to call the instance (prevent rase thread)
        private static object _lock = new();

        //create variable to create new instaise of class (lazy intioalization)
        private static CurrencyConverter _instance;

        //create new prop to return instance
        public static CurrencyConverter Instance
        {
            get {
                // check if create instance 
                if (_instance == null)
                {
                  // Lock to prevent multible thread to call the instance (prevent rase thread)
                    lock ( _lock){

                    //double check if create instance 
                        if (_instance == null)
                {
                    _instance = new ();
                }
                }
              }
                return _instance;
                 }
        }

        private void loadExchangeRates()
        {
            Thread.Sleep(3000);
            _exchaingRates = new[]
            {
                new ExchaingRate("USD","SAR",3.75m),
                new ExchaingRate("USD","EGP",30.60m),
                new ExchaingRate("SAR","EGP",8.16m)
            };
        }

        public decimal Convert(string baseCurrency ,string targetCurrency, decimal amount)
        {
            var exchangeRate = _exchaingRates.FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate.Rate;
                }
    }
}
