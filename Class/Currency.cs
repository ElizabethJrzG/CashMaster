using System;
using System.Collections.Generic;
using System.Text;

namespace CashMaster.Class
{
    class Currency
    {
        public enum CurrencyCode
        {
            MXN,
            USD,
            //// {Add new currency codes above this line}
        }

        // Currency denomination arrays: 
        public static double[] _usaDenomination = { 0.01, 0.05, 0.10, 0.25, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00, 50.00, 100.00 };
        public static double[] _mexicoDenomination = { 0.05, 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00, 50.00, 100.00 };
        //// {Add new currency arrays above this line}

        public static double[] GetDenominationArray(CurrencyCode currencyCode)
        {
            try
            {
                // Create empty denomination array
                double[] _denominationArray = { 0 };

                // Switch denomination array according to the preferred Currency value
                switch (currencyCode)
                {
                    case CurrencyCode.MXN:
                        _denominationArray = _mexicoDenomination;
                        break;
                    case CurrencyCode.USD:
                        _denominationArray = _usaDenomination;
                        break;
                    //// {Add new currency code cases above this line}
                }

                return _denominationArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
