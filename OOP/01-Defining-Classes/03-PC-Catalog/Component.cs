using System;
class Component
{
    private string name;
    private decimal price;
    private string detail;

    //constructors
    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, decimal price, string detail)
        : this (name, price)
    {
        this.Detail = detail;
    }

    // properties
    public string Name
    {
        get { return this.name; }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid component name!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value >= 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("The price must be a positive number!");
            }
        }
    }

    public string Detail
    {
        get { return this.detail; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid component detail!");
            }
            else
            {
                this.detail = value;
            }
        }
    }
}
