using System;
using System.Collections.Generic;
using System.Text;

namespace CashMaster.Class
{
    class PaymentController
    {
        public static PaymentResponse OptimalChangeBack(PaymentRequest request)
        {
            try
            {
                // Initialize class object
                PaymentResponse _paymentResponse = new PaymentResponse();

                // Get denomination array according to the currency code
                double[] _denominationArray = Currency.GetDenominationArray(request.GetCurrencyCode());

                // Get denomination array length
                int _denArrayLength = _denominationArray.Length;

                // Calculate change back quantity
                double _changeBackQty = (request.PaymentBack());

                //Shpw values
                request.showValues();

                if (!Validation.ComparePaymentValues(request))
                {
                    throw new PaymentException("The payment cannot be less than the price. Please try again.");
                }

                // Set value
                _paymentResponse.SetChangeBack(_changeBackQty);

                // Cycle through every denomination
                for (int i = (_denArrayLength - 1); i >= 0; i--)
                {
                    // Find denominations
                    while (_changeBackQty >= _denominationArray[i])
                    {
                        _changeBackQty -= _denominationArray[i];
                        _paymentResponse.GetOptimalChangeBack().Add(_denominationArray[i]);
                    }
                }

                // Show values
                _paymentResponse.showValues();

                return _paymentResponse;
            }
            catch (PaymentException ex)
            {
                ex.showError();
                return null;
            }
        }
    }
}
