namespace _02_Human_Student_Worker
{
    using System;
    using System.Collections.Generic;

    class Student : Human
    {
        private static IList<long> takenFacultyNums;

        private long facultyNum;

        static Student()
        {
            Student.takenFacultyNums = new List<long>();
        }

        public Student(string firstName, string lastName, long facultyNum)
            : base (firstName, lastName)
        {
            this.FacultyNum = facultyNum;
            Student.takenFacultyNums.Add(facultyNum);
        }

        public long FacultyNum
        {
            get { return this.facultyNum; }

            set
            {
                if (value <= 0 || value < 10000 || value >= 10000000000)
                {
                    throw new ArgumentException("Faculty number cannot be zero or negative and must be between 5 and 10 digits!", "FacultyNum");
                }

                if (takenFacultyNums.Contains(value))
                {
                    throw new ArgumentException("The class number was assigned to another student");
                }

                this.facultyNum = value;
            }
        }

        public override string ToString()
        {            
            return String.Format("First name: {0}, last name: {1}, faculty number: {2}.", this.FirstName, this.LastName, this.FacultyNum);
        }
    }
}
