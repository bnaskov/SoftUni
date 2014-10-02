namespace _01_School
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private HashSet<Class> classes;

        public School(HashSet<Class> classes)
        {
            this.Classes = classes;
        }

        public HashSet<Class> Classes { get; set; }
    }
}
