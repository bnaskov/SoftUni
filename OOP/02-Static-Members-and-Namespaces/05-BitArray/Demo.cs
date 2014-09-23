using System;

class Demo
{
    static void Main()
    {
        BitArray num1 = new BitArray(4);
        num1[3] = 1;
        Console.WriteLine(num1);

        BitArray num2 = new BitArray(2);
        num2[0] = 1;
        num2[1] = 1;
        Console.WriteLine(num2);
    }
}
