namespace _01_School
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        private static IList<int> takenClassNumbers;
        private int uniqueClassNumber;
        
        static Student()
        {
            Student.takenClassNumbers = new List<int>();
        }

        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            Student.takenClassNumbers.Add(uniqueClassNumber);
        }

        public Student(string name, int uniqueClassNumber, string detail)
            : this(name, uniqueClassNumber)
        {
            this.Detail = detail;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("UniqueClassNumber cannot be zero or negative number!");
                }

                if (takenClassNumbers.Contains(value))
                {
                    throw new ArgumentException("The class number was assigned to another student");
                }

                this.uniqueClassNumber = value;
            }
        }
    }
}
