namespace StudentClass
{
    using System;

    class StudentSpecialty
    {
        private string specialties;
        private int facultyNumber;

        public StudentSpecialty(string specialties, int facultyNumber)
        {
            this.Specialties = specialties;
            this.FacultyNumber = facultyNumber;
        }

        public string Specialties
        {
            get { return this.specialties; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The argument must not to be empty string or null.", "Specialties");
                }
                this.specialties = value;
            }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The argument must not to be negative or zero.", "FacultyNumber");
                }
                this.facultyNumber = value;
            }
        }        
    }
}
