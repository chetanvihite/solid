

namespace InterfaceSegregation_After
{
    public abstract class OrderProcessor
    {
        public abstract void ProcessOrder();
    }

    public abstract class OnlineOrderProcessor
    {
        public abstract bool ValidatePaymentInfo();
        public abstract bool ValidateShippingAddress();
        public abstract void ProcessOrder();
    }

    public class ECommerceOrder : OnlineOrderProcessor
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

    // Another perspective would be to ---
    public interface IOrderProcessor
    {
        void ProcessOrder();
    }

    public interface IPaymentProcessor
    {
        bool ValidatePaymentInfo();
        void ProcessPayment();
    }

    public interface IShippingHandler
    {
        bool ValidateShippingAddress();
        void StoreShippingDetails();
    }

}
