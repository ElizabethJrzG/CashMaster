using CashMaster.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static CashMaster.Class.Currency;

namespace CashMaster.Class
{
    class PaymentRequest : AbstractPayment, ICalculation
    {
        private double _price = 0;
        private double _payment = 0;
        private CurrencyCode _currencyCode;

        public PaymentRequest()
        {
             this._currencyCode = CurrencyCode.USD;
        }
        public PaymentRequest(CurrencyCode currencyCode)
        {
            this._currencyCode = currencyCode;
        }

        public PaymentRequest(Double Price, Double Payment, CurrencyCode currencyCode)
        {
            this._price = Price;
            this._payment = Payment;
            this._currencyCode = currencyCode;
        }

        public void SetPrice(Double price)
        {
            _price = price;
        }
        public Double GetPrice()
        {
            return _price;
        }

        public void SetPayment(Double payment)
        {
            _payment = payment;
        }
        public Double GetPayment()
        {
            return _payment;
        }

        public void SetCurrencyCode(Currency.CurrencyCode currencyCode)
        {
            this._currencyCode = currencyCode;
        }
        public Currency.CurrencyCode GetCurrencyCode()
        {
            return this._currencyCode;
        }

       

        public override void showValues()
        {
            Console.WriteLine("\nPrice: " + _price);
            Console.WriteLine("Payment: " + _payment);
            Console.WriteLine("Currency: " + _currencyCode);
        }

        public double PaymentBack()
        {
            return this._payment - this._price;
        }
    }
}
