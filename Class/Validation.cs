using System;
using System.Collections.Generic;
using System.Text;

namespace CashMaster.Class
{
    class Validation
    {
        public static bool ComparePaymentValues(PaymentRequest paymentRequest)
        {
            if (paymentRequest.GetPayment() < paymentRequest.GetPrice())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double GetInputDouble(String userInput)
        {
            double _aux=0;
            Boolean _flag = true;
            do
            {
                try
                {
                    Console.WriteLine(userInput);
                    _aux = Convert.ToDouble(Console.ReadLine());
                    _flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Input value type is not valid.");
                    Console.WriteLine(ex.Message);
                }

            } while (_flag);
            return _aux;
            
        }
    }
}
