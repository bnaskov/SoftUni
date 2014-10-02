namespace _02_Human_Student_Worker
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                this.CheckForNullOrEmptyString(value, "FirstName");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                this.CheckForNullOrEmptyString(value, "LastName");
                this.lastName = value;
            }
        }

        private void CheckForNullOrEmptyString(string value, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The argument must not to be empty string or null.", argumentName);
            }
        }
    }
}
