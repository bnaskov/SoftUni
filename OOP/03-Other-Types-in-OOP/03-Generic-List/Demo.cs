namespace _GenericList
{
    using System;

    class Demo
    {
        static void Main()
        {
            // Version:
            var allAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("Version: " + allAttributes[0]);
            Console.WriteLine();

            // Example 1:
            Console.WriteLine("Example 1:");
            GenericList<int> nums = new GenericList<int>(3);
            nums.Add(2);
            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(7);
            Console.WriteLine(nums);

            Console.Write("Accessing element by index [2]: ");
            Console.WriteLine(nums[2]);

            Console.Write("Removing element by index [1]: ");
            nums.RemoveByIndex(1);
            Console.WriteLine(nums);

            Console.Write("Inserting element by index [2], element = 10: ");
            nums.InsertByIndex(2, 10);
            Console.WriteLine(nums);

            Console.Write("The element with the maximum value in the list: ");
            Console.WriteLine(nums.Max());
            Console.Write("The element with the minimum value in the list: ");
            Console.WriteLine(nums.Min());

            Console.Write("Finding element index by value: ");
            Console.WriteLine(nums.FindElement(7));

            Console.Write("Checking if the list contains a value: ");
            Console.WriteLine(nums.Contains(-10));

            Console.Write("Clearing the list: ");
            nums.Clear();
            Console.WriteLine(nums);
            Console.WriteLine();

            // Example 2:
            Console.WriteLine("Example 2:");
            GenericList<string> dogNames = new GenericList<string>(2);
            dogNames.Add("Sharo");
            dogNames.Add("Rex");
            dogNames.Add("Blackie");
            dogNames.Add("Rich");
            dogNames.Add("Bella");
            Console.WriteLine(dogNames);

            Console.Write("Accessing element by index [3]: ");
            Console.WriteLine(dogNames[3]);

            Console.Write("Removing element by index [2]: ");
            dogNames.RemoveByIndex(2);
            Console.WriteLine(dogNames);

            Console.Write("Inserting element by index [0], element = 'Izzy': ");
            dogNames.InsertByIndex(0, "Izzy");
            Console.WriteLine(dogNames);

            Console.Write("The element with the maximum value in the list: ");
            Console.WriteLine(dogNames.Max());
            Console.Write("The element with the minimum value in the list: ");
            Console.WriteLine(dogNames.Min());

            Console.Write("Finding element index by value('Izzy'): ");
            Console.WriteLine(dogNames.FindElement("Izzy"));

            Console.Write("Checking if the list contains a value('Rich'): ");
            Console.WriteLine(dogNames.Contains("Izzy"));       
        }
    }
}