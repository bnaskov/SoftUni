namespace BankOfKK
{
    using System;

    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.GetType().Name.Equals("IndividualCustomer") && months <= 6)
            {
                return 0m;
            }
            else if (this.Customer.GetType().Name.Equals("IndividualCustomer") && months > 6)
            {
                return base.CalculateInterest(months - 6);
            }
            else if (this.Customer.GetType().Name.Equals("CorporateClient") && months <= 12)
            {
                return base.CalculateInterest(months) / 2;
            }
            else
            {
                return base.CalculateInterest(12) / 2 + base.CalculateInterest(months - 12);
            }
        }
    }
}
