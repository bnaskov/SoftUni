using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKK
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer", "Customer cannot be null.");
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
             protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("InterestRate", "Interest rate cannot be a negative number.");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months", "The period cannot be a negative number.");
            }

            decimal calculatedInterest = this.balance * this.interestRate * months;
            return calculatedInterest;
        }

        public virtual void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
