namespace _03_Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base (name, age, Gender.Male)
        {
        }

        public void Eat()
        {
            Console.WriteLine("Tomcat is eating shushi");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myauau");
        }
    }
}
