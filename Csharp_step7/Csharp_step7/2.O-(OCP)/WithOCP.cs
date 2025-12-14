using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithOCP
{
    //interafce

    interface IPaymentMethod
    {
        void ProcessPayment();
    }
    class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
    class DebitCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Debit card payment...");
        }
    }
    class UPIPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing UPI payment...");
        }
    }
    class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing UPI payment...");
        }
    }
    class CryptoPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Crypto payment...");
        }
    }

    class PaymentProcessor
    {
        private void ProcessPayment(IPaymentMethod paymentMethod)
        {
            paymentMethod.ProcessPayment();
        }

        static void Main()
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPaymentMethod creditCardPayment = new CreditCardPayment();
            processor.ProcessPayment(creditCardPayment);

            IPaymentMethod debitCardPayment = new DebitCardPayment();
            processor.ProcessPayment(debitCardPayment);

            IPaymentMethod upiPayment = new UPIPayment();
            processor.ProcessPayment(upiPayment);

            IPaymentMethod paypalPament = new PayPalPayment();
            processor.ProcessPayment(paypalPament);
        }
    }

}