using System;
using System.Collections.Generic;
using System.Text;

namespace CashMaster.Class
{
    class PaymentException : Exception
    {
        public PaymentException()
        {
        }

        public PaymentException(string message)
            : base(message)
        {
        }

        public void showError()
        {
            Console.WriteLine(Message);
        }
    }
}
