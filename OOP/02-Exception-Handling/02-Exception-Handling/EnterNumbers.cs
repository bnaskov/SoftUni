using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }

    private static int ReadNumber(int start, int end)
    {
        int num = start;
        int tempNum = start;
        while (tempNum == num)
        {
            try
            {
                Console.WriteLine("Enter a number between {0} and {1}: ", start, end);
                num = int.Parse(Console.ReadLine());
                while (num <= start || num >= end)
                {
                    Console.WriteLine("Invalid input! Your number must be between {0} and {1}!", start, end);
                    Console.WriteLine("Enter a number between {0} and {1}: ", start, end);
                    num = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number! The number is too big to fit in int32!");
            }
        }
        
        return num;
    }
}
