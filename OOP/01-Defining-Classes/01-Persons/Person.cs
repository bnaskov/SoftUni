using System;
class Person
{
    private string name;
    private int age;
    private string email;
    
    // constructors
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, string.Empty) { }

    // properties
    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("The age must be in the range [1...100]!");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if ((value.Contains("@") && value.Length > 4) || value == string.Empty)
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid e-mail address!");
            }

        }
    }

    // ToString override
    public override string ToString()
    {
        return "Name: " + this.name + "; Age: " + this.age + "; Email: " + (this.email != string.Empty ? this.email : "no email") + ".";
    }
}
