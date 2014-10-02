namespace _01_School
{
    using System;
    using System.Collections.Generic;

    class Teacher : Person
    {
        HashSet<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new HashSet<Discipline>();
        }

        public Teacher(string name, HashSet<Discipline> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, HashSet<Discipline> disciplines, string detail)
            : this(name, disciplines)
        {
            this.Detail = detail;
        }

        public HashSet<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Disciplines can not be null!");
                }

                this.disciplines = value;
            }
        }
    }
}
