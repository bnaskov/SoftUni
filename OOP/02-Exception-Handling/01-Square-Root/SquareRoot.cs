using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter a positive integer: ");
            long num = Int64.Parse(Console.ReadLine());

            if (num < 0)
            {
                throw new ArgumentException("Invalid number!");
            }
            double result = Math.Sqrt(num);
            Console.WriteLine("The square root of {0} is {1:0.##}.", num, result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
