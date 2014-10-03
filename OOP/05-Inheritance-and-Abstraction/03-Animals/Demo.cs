namespace _03_Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Sharo", 3, Gender.Male),
                new Frog("Princess", 2, Gender.Female),
                new Kitten("Milo", 1),
                new Tomcat("Fet", 4),
                new Kitten("Mika", 3),
                new Tomcat("Bob", 5),
                new Dog("Doge", 6, Gender.Male),
                new Dog("Izzy", 4, Gender.Female),
                new Frog("Mich", 3, Gender.Male)
            };

            animals[1].ProduceSound();
            animals[3].ProduceSound();
            animals[6].ProduceSound();
            Console.WriteLine();

            var animalsAverageAge =
                from animal in animals
                group animal by animal.GetType().Name into grp
                select new
                {
                    GroupName = grp.Key,
                    AverageAge = grp.Average(a => a.Age)
                };

            foreach (var animal in animalsAverageAge)
            {
                Console.WriteLine("{0}: average age: {1:0.00}", animal.GroupName, animal.AverageAge);
            }
        }
    }
}
