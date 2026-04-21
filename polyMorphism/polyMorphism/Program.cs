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
            foreach (var p in payments)
            {
                p.ProcessPayment();
            }
        }
    }
    class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment");
        }

    }
    class CreditCard : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing creditcard payment.");
        }
    }
    class Paypal : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing paypal payment.");
        }
    }

    class Cash : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment.");
        }
    }
}
