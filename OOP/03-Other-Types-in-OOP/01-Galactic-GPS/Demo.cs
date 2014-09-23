using System;

class Demo
{
    static void Main()
    {
        Location home = new Location(18.037986, 28.870097, Planet.Earth);
        Console.WriteLine(home);
        // Console.WriteLine(home.Planet);
        
        Location venus = new Location(31.432986, 15.934625, Planet.Venus);
        Console.WriteLine(venus);
    }
}
