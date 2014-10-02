namespace _01_School
{
    using System;
    using System.Collections.Generic;

    class Class : IDetail
    {
        private static IList<string> uniqueIdentifiers;

        private string uniqueIdentifier;
        private HashSet<Teacher> teachers;
        private HashSet<Student> students;
        private string detail;
        
        public Class(string uniqueIdentifier, HashSet<Teacher> teachers, HashSet<Student> students)
        {
            this.UniqueIdentifier = uniqueIdentifier;
            this.Teachers = teachers;
            this.Students = students;
            Class.uniqueIdentifiers.Add(uniqueIdentifier);
        }

        static Class()
        {
            Class.uniqueIdentifiers = new List<string>();
        }

        public string UniqueIdentifier
        {
            get
            {
                return this.uniqueIdentifier;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("UniqueId can not be null or empty!");
                }

                if (uniqueIdentifiers.Contains(value))
                {
                    throw new ArgumentException("There is another class with this identification!");
                }

                this.uniqueIdentifier = value;
            }
        }

        public HashSet<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Teachers", "Teachers can not be null");
                }

                this.teachers = value;
            }
        }

        public HashSet<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Students can not be null");
                }

                this.students = value;
            }
        }

        public string Detail
        {
            get
            {
                return this.detail;
            }

            set
            {
                this.detail = value;
            }
        }
    }
}
