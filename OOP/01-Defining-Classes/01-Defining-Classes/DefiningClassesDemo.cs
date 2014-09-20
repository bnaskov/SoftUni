using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_Defining_Classes
{
    class DefiningClassesDemo
    {
        static void Main()
        {
            // Problem 1.
            Console.WriteLine("Problem 1");
            Person ivan = new Person("Ivan", 23, "ivan@gmail.com");
            Console.WriteLine(ivan.ToString());
            Person gosho = new Person("Gosho", 25);
            Console.WriteLine(gosho.ToString());
            Console.WriteLine("-------------");
            Console.WriteLine();

            // Problem 2
            Console.WriteLine("Problem 2");
            Battery battery = new Battery("lition");
            battery.Capacity = 2000;
            // Console.WriteLine(battery.Capacity);
            // Console.WriteLine(battery.NumberOfCells);
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", 2259.0m, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", 4.5m, "Li-Ion", 4, 2550);
            lenovo.printInfo();
            Console.WriteLine("-------------");
            Laptop asus = new Laptop("Asus SP", 799.9m, "Asus", "Intel i3", 8, "NVIDIA");
            asus.printInfo();
            Console.WriteLine("-------------");

            Laptop dell = new Laptop("Dell EX", 1290);
            dell.printInfo();
            dell.Ram = 20;
            dell.Hdd = 100;
            dell.GraphicsCard = "NVIDIA";
            dell.printInfo();
            Console.WriteLine("-------------");
            Console.WriteLine();

            // Problem 3
            Console.WriteLine("Problem 3");
            Component hdd = new Component("SATA Hard Drive", 250.50m, "500GB 5400 rpm");
            Component processor = new Component("Intel Celeron Dual Core", 190.90m);
            Component ram = new Component("Single Channel DDR3 1600MHz", 120.90m, "4GB");
            Component graficsCard = new Component("Intel HD Graphics", 320.20m);
            Component display = new Component("15.6 inch LED Backlit Display", 280.50m, "HD resolution (1366 x 768)");

            Computer comp1 = new Computer("Dell", hdd, processor, ram);
            Computer comp2 = new Computer("Lenovo", hdd, processor, ram, graficsCard, display);
            Computer comp3 = new Computer("Toshiba", hdd, processor, ram, graficsCard, display);

            List<Computer> computers = new List<Computer>() { comp1, comp2, comp3 };

            computers = computers.OrderBy(computer => computer.Price).ToList();

            foreach (var computer in computers)
            {
                computer.printInfo();
                Console.WriteLine("-------------");
            }
        }
    }
}
