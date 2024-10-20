using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class SindltonRun
    {
        public static void Singlton()
        {

            while (true)
            {

                Console.Write("Enter Base Currency");
                var BaseCurrency = Console.ReadLine();

                Console.Write("Enter Target Currency");
                var TargetCurrency = Console.ReadLine();

                Console.Write("Enter amount");
                var amount = decimal.Parse(Console.ReadLine());

                //create new instanice of obj CurrencyConverter();
                //var converter = new CurrencyConverter();


                //call instance of CurrencyConverter already intiolaization in CurrencyConverter
                var exchaingAmount = CurrencyConverter.Instance.Convert(BaseCurrency, TargetCurrency, amount);

                Console.WriteLine($"{amount} {BaseCurrency} = {exchaingAmount} {TargetCurrency}");

                Console.WriteLine("--------------------");
            }

        }


    }
}
