using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Before
{
    public abstract class OrderProcessor
    {
        public abstract bool ValidatePaymentInfo();
        public abstract bool ValidateShippingAddress();
        public abstract void ProcessOrder();
    }

    public class OnlineOrder : OrderProcessor
    {

        public override bool ValidatePaymentInfo()
        {
            return true;
        }

        public override bool ValidateShippingAddress()
        {
            return true;
        }

        public override void ProcessOrder()
        {
            //place order here if everything is ok.
        }
    }

    public class CashOnDeliveryOrder : OrderProcessor
    {

        public override bool ValidatePaymentInfo()
        {
            throw new NotImplementedException();
        }

        public override bool ValidateShippingAddress()
        {
            throw new NotImplementedException();
        }

        public override void ProcessOrder()
        {
            //place order here if everything is ok.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
