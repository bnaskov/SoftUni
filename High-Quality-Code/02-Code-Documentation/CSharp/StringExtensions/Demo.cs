using System;
using System.Globalization;
using System.Linq;

class ProgramTester
{
    static void Main()
    {
        Console.WriteLine("19871".ToShort());
        Console.WriteLine("1258".ToBoolean());
        Console.WriteLine("2014/10/05".ToDateTime());
        Console.WriteLine("aJona".GetStringBetween("a", "a"));
    }
}

