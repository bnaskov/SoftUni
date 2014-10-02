namespace _01_School
{
    using System;
    using System.Collections.Generic;
    class Demo
    {
        public static void Main()
        {
            Student ivan = new Student("Ivan", 1234567);
            Student george = new Student("George", 1290871);
            Student ani = new Student("Ani", 1290432);
            // Student mike = new Student("mike", 1290871);

            Discipline java = new Discipline("Java", new HashSet<Student>() { ivan, george }, 15);
            Discipline php = new Discipline("PHP", new HashSet<Student>() { ivan, ani }, 10);

            Teacher nakov = new Teacher("Nakov", new HashSet<Discipline>() { java, php });
            Teacher karamfilov = new Teacher("Karamfilov", new HashSet<Discipline>() { php }, "Very punctual!");

            Class schClass = new Class("Robotics", new HashSet<Teacher>() { nakov, karamfilov }, new HashSet<Student>() { ivan, george, ani });
            School MIT = new School(new HashSet<Class>() { schClass });
        }        
    }
}
