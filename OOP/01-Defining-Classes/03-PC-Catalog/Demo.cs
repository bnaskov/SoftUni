using System;
using System.Collections.Generic;
using System.Linq;

class Demo
{
    static void Main()
    {
        Component hdd = new Component("SATA Hard Drive", 250.50m, "500GB 5400 rpm");
        Component processor = new Component("Intel Celeron Dual Core", 190.90m);
        Component ram = new Component("Single Channel DDR3 1600MHz", 120.90m, "4GB");
        Component graficsCard = new Component("Intel HD Graphics", 320.20m);
        Component display = new Component("15.6 inch LED Backlit Display", 280.50m, "HD resolution (1366 x 768)");

        Computer comp1 = new Computer("Dell", hdd, processor, ram);
        Computer comp2 = new Computer("Lenovo", hdd, processor, ram, graficsCard, display);
        Computer comp3 = new Computer("Toshiba", hdd, processor, ram, graficsCard, display);

        List<Computer> computers = new List<Computer>() { comp2, comp3, comp1};

        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            computer.printInfo();
            Console.WriteLine("-------------");
        }
    }
}
