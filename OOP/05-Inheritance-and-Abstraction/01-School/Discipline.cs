namespace _01_School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IDetail
    {
        private string name;
        private int numOfLectures;
        private HashSet<Student> students;
        private string detail;

        public Discipline(string name, HashSet<Student> students, int numOfLectures, string detail = null)
        {
            this.Name = name;
            this.Students = students;
            this.NumOfLectures = numOfLectures;
            this.Detail = detail;
        }

        public HashSet<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students list can not be null!");
                }

                this.students = value;
            }
        }

        public int NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures cannot be negative!");
                }

                this.numOfLectures = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name can not be null or empty!");
                }

                this.name = value;
            }
        }

        public string Detail
        {
            get { return this.detail; }

            set
            {
                this.detail = value;
            }
        }
    }
}
