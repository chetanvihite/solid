



namespace OpenClosed_before
{
    public class TaxCalculator
    {
        // the only problem with this class is the method is prone to change in near future
        // caution - stay away from Switch case statements which are prone to get extended over the period of time
        public decimal CalculateTax(decimal amount, string country)
        {
            decimal taxAmount = 0;
            switch (country)
            {
                case "USA":
                    //calculate tax as per USA rules
                    // check state
                    // check some rule 
                    break;
                case "UK":
                    //calculate tax as per UK rules
                    break;
                case "IN":
                    //calculate tax as per India rules
                    break;
            }
            return taxAmount;
        }
    }
}
