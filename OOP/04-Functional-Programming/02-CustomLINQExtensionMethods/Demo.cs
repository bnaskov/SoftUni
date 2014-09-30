using System;
using System.Collections.Generic;
using System.Linq;

class Demo
{
    static void Main()
    {
        IEnumerable<int> numbers = new List<int>() { 12, 18, 32, 15, 12};
        Console.WriteLine(string.Join(", ", numbers.WhereNot(x => x == 12)));

        //IEnumerable<int> filtererNums = numbers.WhereNot(x => x == 12);
        //foreach (var num in filtererNums)
        //{
        //    Console.WriteLine(num);
        //}

        Console.WriteLine(string.Join(", ",numbers.Repeat(2)));

        List<string> words = new List<string>() { "dog", "exes", "woman", "fog", "city", "parameter"};
        List<string> suffixes = new List<string>() { "og", "meter", "xes" };
        Console.WriteLine(string.Join(", ", words.WhereEndsWith(suffixes)));
    }
}
