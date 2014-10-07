namespace BankOfKK
{
    using System;

    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }        

        public void Withdraw(decimal sum)
        {
            if (this.Balance < sum)
            {
                throw new ArithmeticException("Insufficient amount.");
            }

            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
