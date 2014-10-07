namespace BankOfKK
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if ((this.Customer.GetType().Name.Equals("IndividualCustomer") && months <= 3)
                || (this.Customer.GetType().Name.Equals("CorporateClient") && months <= 2))
            {
                return 0m;
            }
            else if(this.Customer.GetType().Name.Equals("IndividualCustomer"))
            {
                return base.CalculateInterest(months - 3);
            }
            else
            {
                return base.CalculateInterest(months - 2);
            }
        }
    }
}
