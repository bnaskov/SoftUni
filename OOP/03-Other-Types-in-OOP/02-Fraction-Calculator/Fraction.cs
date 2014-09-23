using System;

public struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator)
        : this()
    {
        long gcd = Fraction.GCD(numerator, denominator);
        this.Numerator = numerator / gcd;
        this.Denominator = denominator / gcd;
    }

    public long Numerator
    {
        get
        {
            return this.numerator;
        }
        set
        {
            this.numerator = value;
        }
    }

    public long Denominator
    {
        get
        {
            return this.denominator;
        }
        set
        {
            if (value != 0)
            {
                this.denominator = value;
            }
            else
            {
                throw new ArgumentException("The denominator cannot be 0!");
            }
        }
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator -
        f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;
        return new Fraction(num, denom);
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator +
        f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;
        return new Fraction(num, denom);
    }

    private static long GCD(long num1, long num2)
    {
        long Remainder;

        while (num2 != 0)
        {
            Remainder = num1 % num2;
            num1 = num2;
            num2 = Remainder;
        }

        return num1;
    }

    public override string ToString()
    {
        return ((decimal)this.numerator / this.denominator).ToString();
    }
}
