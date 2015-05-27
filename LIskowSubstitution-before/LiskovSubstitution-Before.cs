
using System;
using System.Collections.Generic;

namespace LIskowSubstitution_before
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class SpecialCustomers
    {
        List<Customer> list = new List<Customer>();

        public virtual void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }
    public class TopNCustomers : SpecialCustomers
    {
        private int maxCount = 5;
        List<Customer> list = new List<Customer>();
        public override void AddCustomer(Customer obj)
        {
            if (list.Count < maxCount)
            {
                list.Add(obj);
            }
            else
            {
                throw new Exception("Only " + maxCount + " customers can be added.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SpecialCustomers sc = null;
            sc = new TopNCustomers();
            for (int i = 0; i < 10; i++)
            {
                Customer obj = new Customer();
                sc.AddCustomer(obj);
            }
        }
    }
}
