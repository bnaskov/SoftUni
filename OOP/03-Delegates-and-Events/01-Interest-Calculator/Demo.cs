using System;

class Demo
{
    static void Main()
    {
        InterestCalculator calcCompoundInterest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
        Console.WriteLine("{0:0.0000}", calcCompoundInterest.TotalMoney);

        InterestCalculator calcSimpleInterest = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
        Console.WriteLine("{0:0.0000}", calcSimpleInterest.TotalMoney);       
    }

    public static decimal GetSimpleInterest(decimal sum, double interest, int years)
    {
        decimal simpleInterest = sum * (decimal)(1 + (interest * years / 100));
        return simpleInterest;
    }

    public static decimal GetCompoundInterest(decimal sum, double interest, int years)
    {
        decimal compoundInterest = sum * (decimal)Math.Pow(1 + (interest / 100 / 12), years * 12);
        return compoundInterest;
    }
}
