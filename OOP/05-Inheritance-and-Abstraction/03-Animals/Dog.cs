namespace _03_Animals
{
    using System;

    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base (name, age, gender)
        {
        }

        public void Fetch()
        {
            Console.WriteLine("Dog is playing fetch");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark, wow");
        }
    }
}
