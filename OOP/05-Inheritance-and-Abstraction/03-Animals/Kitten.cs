namespace _03_Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender = Gender.Female)
            : base (name, age, gender)
        {
        }

        public void PlayWithToy()
        {
            Console.WriteLine("Kitten is playing with the toy.");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myau");
        }
    }
}
