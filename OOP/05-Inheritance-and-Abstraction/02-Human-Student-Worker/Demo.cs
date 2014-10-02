namespace _02_Human_Student_Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            List<Student> students = new List<Student>() {
                new Student("Ivan", "Ivanov", 110100),
                new Student("Dimitar", "Draganov", 110110),
                new Student("Ivan", "Milev", 110102),
                new Student("Dimityr", "Penev", 110105),
                new Student("Ani", "Genova", 110114),
                new Student("Mira", "Petkova", 110122),
                new Student("Niki", "Popov", 110109),
                new Student("Mira", "Siderova", 110108),
                new Student("Nadia", "Kerin", 110125),
                new Student("Jon", "Snow", 110119)
            };

            List<Worker> workers = new List<Worker>() {
                new Worker("Jon", "Snow", 2050m, 8),
                new Worker("Daenerys", "Targaryen", 120000m, 12),
                new Worker("Cersei", "Lannister", 15200m, 4),
                new Worker("Jaime", "Lannister", 4000, 10),
                new Worker("Tyrion", "Lannister", 6000, 12),
                new Worker("Sansa", "Stark", 1000m, 4),
                new Worker("Jon", "Rain", 1500m, 2),
                new Worker("Cersei", "Stark", 9000m, 9),
                new Worker("Arya", "Stark", 2000m, 8),
                new Worker("Theon", "Grayjoy", 0m, 16)
            };

            var studentsSortedFacNum = students.OrderBy(s => s.FacultyNum);
            foreach (var student in studentsSortedFacNum)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            
            var workersPayPerHour = workers.OrderBy(w => w.MoneyPerHour)
                .Select(w => new { FistName = w.FirstName, LastName = w.LastName, MoneyPerHour = w.MoneyPerHour });
            foreach (var worker in workersPayPerHour)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName)
                .Select(h => new { FistName = h.FirstName, LastName = h.LastName });
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
