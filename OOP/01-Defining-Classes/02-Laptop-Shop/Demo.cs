using System;

class Demo
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("-------------");
        dell.Ram = 20;
        dell.Hdd = 100;
        dell.GraphicsCard = "NVIDIA";
        dell.printInfo();
    }
}
