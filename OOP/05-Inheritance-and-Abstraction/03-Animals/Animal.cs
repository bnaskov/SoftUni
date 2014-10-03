namespace _03_Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name", "Name cannot be an null or empty string.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age can not be a negative number.");
                }

                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }

        public abstract void ProduceSound();
    }
}
