namespace _03_Animals
{
    using System;

    class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base (name, age, gender)
        {
        }

        public void Jump()
        {
            Console.WriteLine("Jumping like a frog.");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kvak, blob.");
        }
    }
}
