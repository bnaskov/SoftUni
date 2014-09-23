using System;

class Demo
{
    static void Main()
    {
        try
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            Console.WriteLine("Please enter fraction1 numerator: ");
            fraction1.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fraction2 numerator: ");
            fraction1.Denominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fraction1 denominator: ");
            fraction2.Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fraction2 denominator: ");
            fraction2.Denominator = int.Parse(Console.ReadLine());

            Fraction additionResult = fraction1 + fraction2;
            Fraction substractionResult = fraction1 - fraction2;

            Console.WriteLine(additionResult.Numerator);
            Console.WriteLine(additionResult.Denominator);
            Console.WriteLine(additionResult);
            Console.WriteLine(substractionResult);
        }
        catch (ArgumentException aex)
        {
            Console.WriteLine(aex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid number! " + ex.Message);
        }
    }
}
