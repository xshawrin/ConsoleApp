using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>()
            {
                new CreditCard(),
                new Paypal(),
                new Cash()
            };
            double amount = 100;
            foreach (var p in payments)
            {
                Console.WriteLine($"Processing payment of ${p.ProcessPayment(amount)}.");
                Console.WriteLine(p.GetPaymentType());
                Console.WriteLine();
            }
        }
    }
    class Payment
    {
       // public virtual void ProcessPayment()// void type
      // public virtual string ProcessPayment()//string type
       public virtual double ProcessPayment(double amount)
        {
            //Console.WriteLine("Processing payment");// void type
           // return "Process payment.";//string type
           return amount;
        }
        public virtual string GetPaymentType()
        {
            return "Payment type.";
        }

    }
    class CreditCard : Payment
    {
        //public override void ProcessPayment()//void 1
       // public override string ProcessPayment()// string
        public override double ProcessPayment(double amount)
        {
            return amount;
           // return "Processing creditcard payment.";
        
            //Console.WriteLine("Processing creditcard payment.");//void
        }
        public override string GetPaymentType()
        {
            return " :Credit card";
        }

    }
    class Paypal : Payment //2
    {
        // public override void ProcessPayment()
        //public override string ProcessPayment()
        public override double ProcessPayment(double amount)
        {
            return amount;
            //return "Processing paypal payment.";
            // Console.WriteLine("Processing paypal payment.");
        }
        public override string GetPaymentType()
        {
            return " :Paypal";
        }
    }

    class Cash : Payment//3
    {
        // public override void ProcessPayment()
       // public override string ProcessPayment()
            public override double ProcessPayment(double amount)
        {
            return amount;
            
           // return "Processing cash payment.";      
           //Console.WriteLine("Processing cash payment.");
        }
        public override string GetPaymentType()
        {
            return " :Cash";
        }
    }
}
