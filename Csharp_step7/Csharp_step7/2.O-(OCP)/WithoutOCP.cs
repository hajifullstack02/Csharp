using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithoutOCP
{
    class PaymentProcessor
    {


        //When paymenttype is CreditCard i want to prepare some logic....    // Vasavi


        //When paymenttype is DebitCard i want to prepare some logic....    // Haji


        //When paymenttype is Phone pay i want to prepare some logic....    // Sahiti

        //When paymenttype is Google pay i want to prepare some logic....    // Raju

        //When paymenttype is Paytm i want to prepare some logic....       // Bhanu


        //When paymenttype is Paytm i want to prepare some logic....  paypal   //geyasir

        private void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard")    // Logic   Failure Success amount tansaction
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if (paymentType == "DebitCard")
            {
                Console.WriteLine("Processing Debit card payment...");
            }
            else if (paymentType == "PhonePay")
            {
                Console.WriteLine("Processing Phone pay payment...");
            }
            else if (paymentType == "GooglePay")
            {
                Console.WriteLine("Processing Phone pay payment...");
            }
            else if (paymentType == "Paytm")
            {
                Console.WriteLine("Processing Phone pay payment...");
            }
        }
    }
}