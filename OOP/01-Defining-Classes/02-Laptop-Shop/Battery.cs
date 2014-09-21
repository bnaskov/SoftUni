using System;

class Battery
{
    private string type;
    private int numberOfCells;
    private int capacity;

    // constructors
    public Battery(string type)
    {
        this.Type = type;
    }

    public Battery(string type, int numberOfCells)
        : this(type)
    {
        this.NumberOfCells = numberOfCells;
    }

    public Battery(string type, int numberOfCells, int capacity)
        : this(type, numberOfCells)
    {
        this.Capacity = capacity;
    }

    // properties
    public string Type
    {
        get { return this.type; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid type!");
            }
            else
            {
                this.type = value;
            }
        }
    }

    public int NumberOfCells
    {
        get { return this.numberOfCells; }
        set
        {
            if (value > 2 && value < 13)
            {
                this.numberOfCells = value;
            }
            else
            {
                throw new ArgumentException("Invalid number of cells!");
            }
        }
    }

    public int Capacity
    {
        get { return this.capacity; }
        set
        {
            if (value >= 750 && value <= 3600)
            {
                this.capacity = value;
            }
            else
            {
                throw new ArgumentException("Invalid capacity!");
            }
        }
    }
}
