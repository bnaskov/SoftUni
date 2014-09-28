using System;

class InterestCalculator
{
    private decimal money;
    private double interest;
    private int years;
    private decimal totalMoney;

    public InterestCalculator(decimal money, double interest, int years, CalculateInterest calcInterest)
    {
        this.Money = money;
        this.Interest = interest;
        this.Years = years;
        this.TotalMoney = calcInterest(money, interest, years);
    }

    public delegate decimal CalculateInterest(decimal sumOfMoney, double interest, int years); 

    public decimal Money 
    { 
        get
        {
            return this.money;
        }
        set
        {
            if (value >= 0)
            {
                this.money = value;
            }
            else
            {
                throw new ArgumentException("Money cannot be a negative number!");
            }
        }
    }

    public double Interest
    {
        get
        {
            return this.interest;
        }
        set
        {
            if (value >=0)
            {
                this.interest = value;
            }
            else
            {
                throw new ArgumentException("Interest cannot be a negative number!");
            }
        }
    }

    public int Years
    {
        get
        {
            return this.years;
        }
        set
        {
            if (value >= 0)
            {
                this.years = value;
            }
            else
            {
                throw new ArgumentException("Years cannot be a negative number!");
            }
        }
    }

    public decimal TotalMoney
    {
        get { return this.totalMoney; }
        private set { this.totalMoney = value; }
    }
}
