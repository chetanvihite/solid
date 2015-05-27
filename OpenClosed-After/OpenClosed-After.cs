
using System.Collections;
using System.Collections.Generic;

namespace OpenClosed_After
{
    public abstract class TaxCalculatorBase
    {
        public decimal TotalAmount { get; set; }
        public abstract decimal CalculateTax();
    }

    public class UsaTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per USA rules
            return 0;
        }
    }

    public class UkTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per UK rules
            return 0;
        }
    }

    public class IndiaTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per India rules
            return 0;
        }
    }
    public class CanadaTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per canada rules
            return 0;
        }
    }
    public class TaxStrategy
    {
        public static Dictionary<string, TaxCalculatorBase> List = new Dictionary<string, TaxCalculatorBase>();

        private TaxStrategy()
        {
            List.Add("India", new IndiaTax());
            List.Add("USA", new UsaTax());
            List.Add("UK", new UkTax());
            List.Add("Can", new CanadaTax());
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // observe that in future if i have more countries to calcualte tax on, then i dont need to modify any of 
            // existing classes, they will remain as-is.
            // one more advantage is now all my classes have Single Responsibility
            var country = "India";
            var calculatedTax = TaxStrategy.List[country].CalculateTax();

        }
    }
}
