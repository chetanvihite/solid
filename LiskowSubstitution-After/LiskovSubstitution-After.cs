using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowSubstitution_After
{
    public class Customer
    {
        public string CustomerId { get; set; }
    }

    public abstract class CustomerCollection
    {
        public abstract void AddCustomer(Customer obj);
        public abstract int Count { get; }
    }

    
    public class SpecialCustomers : CustomerCollection
    {
        List<Customer> list = new List<Customer>();

        public override void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }

        public override int Count
        {
            get
            {
                return list.Count;
            }
        }
    }

    public class TopNCustomers : CustomerCollection
    {
        private int count = 0;
        Customer[] list = new Customer[5];

        public override void AddCustomer(Customer obj)
        {
            if (count < 5)
            {
                list[count] = obj;
                count++;
            }
            else
            {
                throw new Exception("Only " + count + " customers can be added.");
            }
        }

        public override int Count
        {
            get
            {
                return list.Length;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer() { CustomerId = "Digital" };
            CustomerCollection collection = null;
            collection = new SpecialCustomers();
            collection.AddCustomer(c);

            // the difference is, when we add to TopNCustomers and if we get an exception, we will know that 
            // its becuase of TopNCusrtomer. however in previous case we were cluesless
            collection = new TopNCustomers();
            collection.AddCustomer(c);
        }
    }
}
