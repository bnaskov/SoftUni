using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfKK
{
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }
    }    
}
