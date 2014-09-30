using System;
using System.Collections.Generic;

namespace StudentClass
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(
            string firstName,
            string lastName,
            int age,
            int facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.CheckForNullOrEmptyString(value, "FirstName");
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.CheckForNullOrEmptyString(value, "LastName");
                this.lastName = value;
            }
        }

        public int Age 
        { 
            get
            {
                return this.age;
            }
            private set
            {
                this.CheckForNegativeOrZero(value, "Age");
                this.age = value;
            }
        }


        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                this.CheckForNegativeOrZero(value, "FacultyNumber");
                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            private set
            {
                this.CheckForNullOrEmptyString(value, "Phone");
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!value.Contains("@") || value.Length < 3)
                {
                    throw new ArgumentException("Invalid email.", value);
                }
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Marks list can not be null!", "Marks");
                }

                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                this.CheckForNegativeOrZero(value, "GroupNumber");
                this.groupNumber = value;
            }
        }

        public void CheckForNullOrEmptyString(string value, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The argument must not to be empty string or null.", argumentName);
            }
        }

        public void CheckForNegativeOrZero(decimal value, string argumentName)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The argument must not to be negative or zero.", argumentName);
            }
        }

        //public override string ToString()
        //{
        //    return String.Format("First name: {0}, last name: {1}, age: {2}, faculty number: {3}, phone: {4}, email: {5}, group number: {6}.", this.firstName, this.lastName, this.age, this.facultyNumber, this.phone, this.email, this.groupNumber);
        //}

        public string printInfo()
        {
            return String.Format("First name: {0}, last name: {1}, age: {2}.", this.firstName, this.lastName, this.age);
        }
    }
}
