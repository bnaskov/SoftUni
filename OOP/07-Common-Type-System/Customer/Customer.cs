namespace Customer
{
    using System;
    using System.Collections.Generic;

    class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(
            string firstName,
            string middleName,
            string lastName,
            string id,
            string permanentAddress,
            string phone,
            string email,
            IList<Payment> payments,
            CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.Phone = phone;
            this.Email= email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string PermanentAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; set; }
        public CustomerType CustomerType { get; set; }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;
            if (customer == null)
            {
                return false;
            }                
            if (!Object.Equals(this.Id, customer.Id))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}, last name: {1}, permanent address: {2}, email : {3}, customer type : {4}",
                this.FirstName, this.LastName, this.PermanentAddress, this.Email, this.CustomerType);
        }

        public static bool operator ==(Customer customer1,
                                  Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1,
                           Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public object Clone()
        {
            Customer original = this;
            var originalFirstName = original.FirstName;
            var originalMiddleName = original.MiddleName;
            var originalLastName = original.LastName;
            var originalID = original.Id;
            var originalAddress = original.PermanentAddress;
            var originalPhone = original.Phone;
            var originalEmail = original.Email;
            var originalPayments = original.Payments;
            var originalCustomerType = original.CustomerType;

            Customer clonedCustomer = new Customer(originalFirstName, originalMiddleName, originalLastName,
                originalID, originalAddress, originalPhone, originalEmail, originalPayments, originalCustomerType);

            return clonedCustomer;
        }

        public int CompareTo(Customer other)
        {
            if (!Object.Equals(this.FirstName, other.FirstName))
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (!Object.Equals(this.MiddleName, other.MiddleName))
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (!Object.Equals(this.LastName, other.LastName))
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (!Object.Equals(this.Id, other.Id))
            {
                return this.Id.CompareTo(other.Id);
            }

            return 0;
        }
    }
}
