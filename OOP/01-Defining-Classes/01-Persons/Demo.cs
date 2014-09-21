using System;

class Demo
{
    static void Main()
    {
        Person ivan = new Person("Ivan", 23, "ivan@gmail.com");
        Console.WriteLine(ivan.ToString());
        Person gosho = new Person("Gosho", 25);
        Console.WriteLine(gosho.ToString());
    }
}
