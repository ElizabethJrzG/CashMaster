using System;
using System.Collections.Generic;
using System.Text;

namespace CashMaster.Class
{
    class PaymentResponse : AbstractPayment
    {
        private double _changeBack;
        private List<double> _optimalChangeBack;

        public PaymentResponse()
        {
            // Initialize list
            _optimalChangeBack = new List<double>();
        }

        public double GetChangeBack()
        {
            return this._changeBack;
        }

        public void SetChangeBack(double changeBack)
        {
            this._changeBack = changeBack;
        }

        public List<double> GetOptimalChangeBack()
        {
            return this._optimalChangeBack;
        }

        public void SetOptimalChangeBack(List<double> optimalChangeBack)
        {
            this._optimalChangeBack = optimalChangeBack;
        }

        public override void showValues()
        {
            Console.WriteLine("Your change back is: " + _changeBack);

            // Check if there's change back
            if (_changeBack != 0)
            {
                Console.WriteLine("The optimal change back denomination would be: " +
                              String.Join(", ", _optimalChangeBack));
            }
        }
    }
}
