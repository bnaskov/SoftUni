namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Demo
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 22, 1112110, "+359 2 666 666", "ivan@gmail.com", new List<int>{5, 6, 6}, 1),
                new Student("Ivan", "Dimitrov", 24, 1112112, "+3592 0888 345 987", "ivan@abv.bg", new List<int>{4, 4, 3}, 2),
                new Student("Georgi", "Petkov", 26, 1112111, "0888 811 822", "georgi@abv.bg", new List<int>{6, 6, 6}, 2),
                new Student("Petko", "Penev", 21, 1121143, "02 7217 321", "petko@abv.bg", new List<int>{6, 5, 2, 2}, 1),
                new Student("Maria", "Mikova", 22, 1121142, "0878 200 300", "maria@mail.com", new List<int>{6, 3, 4, 4}, 2),
                new Student("Iva", "Mirova", 28, 1112108, "02 7234 000", "iva@get.bg", new List<int>{3, 5, 2, 2,}, 2)
            };

            // Problem 4. Students by Group
            Console.WriteLine("Problem 4. Students by Group");
            var studentsInOrder = students.OrderBy(student => student.FirstName);
            foreach (var student in studentsInOrder)
            {
                if (student.GroupNumber == 2)
                {
                    Console.WriteLine(student.printInfo());
                }
            }

            Console.WriteLine();

            // Problem 5. Students by First and Last Name
            Console.WriteLine("Problem 5. Students by First and Last Name");
            foreach (var student in students)
            {
                if (string.Compare(student.FirstName, student.LastName) == -1)
                {
                    Console.WriteLine(student.printInfo());
                }
            }

            Console.WriteLine();

            // Problem 6. Students by Age
            Console.WriteLine("Problem 6. Students by Age");
            var studentsByAge = students.Where(s => s.Age >= 18 && s.Age <= 24)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age });
            foreach (var student in studentsByAge)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Problem 7. Sort Students
            Console.WriteLine("Problem 7. Sort Students");
            var sortedStudentByName = students.OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);
            foreach (var student in sortedStudentByName)
            {
                Console.WriteLine(student.printInfo());
            }

            Console.WriteLine();
            var querySortStudents =
                from s in students
                orderby s.FirstName + s.LastName descending
                select s;

            foreach (var student in querySortStudents)
            {
                Console.WriteLine(student.printInfo());
            }

            Console.WriteLine();

            // Problem 8. Filter Students by Email Domain
            Console.WriteLine("Problem 8. Filter Students by Email Domain");
            var filteredByEmail = students.Where(s => s.Email.Contains("@abv.bg"))
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Email = s.Email });
            foreach (var student in filteredByEmail)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Problem 9. Filter Students by Phone
            Console.WriteLine("Problem 9. Filter Students by Phone");
            var filteredByPhone = students.Where(s => s.Phone.Contains("02") || s.Phone.Contains("+3592") || s.Phone.Contains("+359 2"))
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Phone = s.Phone });
            foreach (var student in filteredByPhone)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Problem 10. Excellent Students
            Console.WriteLine("Problem 10. Excellent Students");
            var excellentStudents = students.Where(s => s.Marks.Contains(6))
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });
            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0} {{ {1} }}", student.FullName, string.Join(", ", student.Marks));
            }    

            Console.WriteLine();

            // Problem 11. Weak Students
            Console.WriteLine("Problem 11. Weak Students");
            var weakStudents = students.Where(s => s.Marks.Where(m => m == 2).Count() == 2)
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });
            foreach (var student in weakStudents)
            {
                Console.WriteLine("{0} {{ {1} }}", student.FullName, string.Join(", ", student.Marks));
            } 

            Console.WriteLine();

            // Problem 12. Students Enrolled in 2014
            Console.WriteLine("Problem 12. Students Enrolled in 2014");
            var enrolledThisYear = students.Where(s => s.FacultyNumber.ToString().Substring(4, 2).Equals("14"))
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, FacultyNumber = s.FacultyNumber });
            foreach (var student in enrolledThisYear)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // 13. Students by Groups
            Console.WriteLine("13. Students by Groups");
            var studentsByGroups = students.GroupBy(s => s.GroupNumber, (g, s) => s);
            foreach (var studentsGroup in studentsByGroups)
            {
                Console.WriteLine("Group number {0}", studentsGroup.First().GroupNumber);

                foreach (var student in studentsGroup)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }

            // 14. Students Joined To Specialties
            Console.WriteLine("14. Students Joined To Specialties");
            var studentSpecialties = new List<StudentSpecialty>
            {
                new StudentSpecialty("Web Developer", 1112110),
                new StudentSpecialty("Web Developer", 1112112),
                new StudentSpecialty("PHP Developer", 1112111),
                new StudentSpecialty("PHP Developer", 1121143),
                new StudentSpecialty("QA Engineer", 1121142),
                new StudentSpecialty("Web Developer", 1112108)
            };

            var studentsJoinedToSpecialties = students
                .Join(studentSpecialties,
                    s => s.FacultyNumber,
                    sp => sp.FacultyNumber,
                    (s, sp) =>
                        new
                        {
                            FullName = s.FirstName + " " + s.LastName,
                            FacultyNumber = s.FacultyNumber,
                            Specialty = sp.Specialties
                        })
                .OrderBy(s => s.FullName);
            foreach (var student in studentsJoinedToSpecialties)
            {
                Console.WriteLine(student);
            }
        }
    }
}
