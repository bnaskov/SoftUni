using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKK
{
    class Demo
    {
        static void Main()
        {
            Customer individualCustomer = new IndividualCustomer("Individual customer");
            Customer corporateClient = new CorporateClient("Corporate client");

            Account[] accounts = new Account[]{
                new DepositAccount(individualCustomer, 100, 0.1m),
                new DepositAccount(corporateClient, 1000, 0.2m),
                new LoanAccount(individualCustomer, 10000, 0.5m),
                new LoanAccount(corporateClient, 5000, 0.2m),
                new MortgageAccount(individualCustomer, 12000, 0.12m),
                new MortgageAccount(corporateClient, 100000, 0.5m)
            };

            Console.WriteLine("Calculated interest for 6 months:");
            foreach (var account in accounts)
            {
                Console.WriteLine("{0} interest of {1}: {2}", account.GetType().Name, account.Customer.Name, account.CalculateInterest(6));
            }
            Console.WriteLine();

            Console.WriteLine("Calculated interest for 12 months:");
            foreach (var account in accounts)
            {
                Console.WriteLine("{0} interest of {1}: {2}", account.GetType().Name, account.Customer.Name, account.CalculateInterest(12));
            }


        }
    }
}
