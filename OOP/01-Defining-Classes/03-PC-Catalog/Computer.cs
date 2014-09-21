using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<Component> components = new List<Component>();
    private decimal price;

    // constructors
    public Computer(string name, Component hdd, Component processor, Component ram)
    {
        this.Name = name;
        this.components.Add(hdd);
        this.components.Add(processor);
        this.components.Add(ram);
        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
    }

    public Computer(string name, Component hdd, Component processor, Component ram, Component graficsCard, Component display)
        :this (name, hdd, processor, ram)
    {
        this.components.Add(graficsCard);
        this.components.Add(display);
        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
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
        get
        {
            return this.price;
        }
    }

    // method
    public void printInfo()
    {
        Console.WriteLine("{0} - {1:f2} BGN", this.Name, this.Price);
        foreach (var component in this.components)
        {
            Console.WriteLine("    - {0} {1:f2} BGN {2}", component.Name, component.Price, component.Detail);
        }
    }

}
