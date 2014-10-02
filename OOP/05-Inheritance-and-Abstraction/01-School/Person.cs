namespace _01_School
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : IDetail
    {
        private string name;
        private string detail;

        protected Person(string name)
        {
            this.Name = name;
        }

        protected Person(string name, string detail)
            : this(name)
        {
            this.Detail = detail;
        }

        public string Name 
        { 
            get { return this.name; }
            
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
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
