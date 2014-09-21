using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hdd;
    private string screen;
    private Battery battery;
    private decimal batteryLife;
    private decimal price;

    // constructors
    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
    }

    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard,
        int hdd, string screen, decimal batteryLife, string type, int numberOfCells, int capacity) 
        : this (model, price, manufacturer, processor, ram, graphicsCard)
    {
        this.Hdd = hdd;
        this.Screen = screen;
        this.BatteryLife = batteryLife;
        this.battery = new Battery(type, numberOfCells, capacity);
    }

    // properties
    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid model!");
            }
            else
            {
                this.model = value;
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid manufacturer!");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid processor!");
            }
            else
            {
                this.processor = value;
            }
        }
    }

    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value > 0 && value <= 32)
            {
                this.ram = value;
            }
            else
            {
                throw new ArgumentException("RAM must be in the range [1...32]!");
            }
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid graphics card!");
            }
            else
            {
                this.graphicsCard = value;
            }
        }
    }

    public int Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value > 0 && value <= 2048)
            {
                this.hdd = value;
            }
            else
            {
                throw new ArgumentException("HDD must be in the range [1...1024]!");
            }
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid screen type!");
            }
            else
            {
                this.screen = value;
            }
        }
    }

    public decimal BatteryLife
    {
        get { return this.batteryLife; }
        set{
            if (value > 0 && value <= 10)
            {
                this.batteryLife = value;
            }
            else
            {
                throw new ArgumentException("Battery life must be in the range (0...10]!");
            }
        }            
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price must be a positive number!");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public void printInfo() // this method prints the information about the laptop, ToString override is implemented in the previous task
    {
        if (this.model != null)
        {
            Console.WriteLine("Model: " + this.model);
        }
        if (this.manufacturer != null)
        {
            Console.WriteLine("Manufacturer: " + this.manufacturer);
        }
        if (this.processor != null)
        {
            Console.WriteLine("Processor: " + this.processor);
        }
        if (this.ram > 0)
        {
            Console.WriteLine("RAM: " + this.ram + " GB");
        }
        if (this.graphicsCard != null)
        {
            Console.WriteLine("Graphics Card: " + this.graphicsCard);
        }
        if (this.hdd > 0)
        {
            Console.WriteLine("HDD: " + this.hdd + "GB");
        }
        if (this.screen != null)
        {
            Console.WriteLine("Screen: " + this.screen);
        }
        if (this.battery != null)
        {
            Console.Write(this.battery.Type);
            if (this.battery.NumberOfCells > 0)
            {
                Console.Write(", " + this.battery.NumberOfCells + "-cells");
            }
            if (this.battery.Capacity > 0)
            {
                Console.Write(", " + this.battery.Capacity + " mAh");
            }
            Console.WriteLine();
        }
        if (this.batteryLife > 0)
        {
            Console.WriteLine("Battery Life: " + this.batteryLife + " hours");
        }
        if (this.price > 0)
        {
            Console.WriteLine("Price: " + this.price + " lv.");
        }
    }
}
