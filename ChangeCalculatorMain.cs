using CashMaster.Class;
using System;

namespace CashMaster
{
    class ChangeCalculatorMain
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Cash Master Calculator!");

                // Instanciate payment request object
                PaymentRequest _paymentRequest = new Class.PaymentRequest();

                //// {Change preferred currency code here}
                //  _paymentRequest.SetCurrencyCode(Class.Currency.CurrencyCode.MXN);

                // Ask user to input price
                _paymentRequest.SetPrice(Validation.GetInputDouble("\nWrite price to be paid: "));

                // Ask user to input payment quantity
                _paymentRequest.SetPayment(Validation.GetInputDouble("\nWrite payment quantity: "));

                // Get optimal change back
                PaymentController.OptimalChangeBack(_paymentRequest);

                // Exit
                Console.WriteLine("\nDo you want to continue (Y/N)? ");
            } while (Console.ReadLine().ToUpper().Equals("Y") );


        }

       protected static void CalculatorTest(){
         do{
         // Test function
         Double _price=10,_payment=100; // Declare custom test values

         // Instanciate payment request object
         PaymentRequest _paymentRequest = new Class.PaymentRequest();

         //// {Change preferred currency code here}
         //  _paymentRequest.SetCurrencyCode(Class.Currency.CurrencyCode.MXN);

         // Show test values
         _paymentRequest.SetPrice(Validation.GetInputDouble("\nPrice to be paid: ")+": "+_price);
         _paymentRequest.SetPayment(Validation.GetInputDouble("\nPayment quantity: "+_payment));

        // Get optimal change back
        PaymentController.OptimalChangeBack(_paymentRequest);

        // Exit
        Console.WriteLine("\nDo you want to continue (Y/N)? ");
          } while (Console.ReadLine().ToUpper().Equals("Y") );
       }
    }
}
