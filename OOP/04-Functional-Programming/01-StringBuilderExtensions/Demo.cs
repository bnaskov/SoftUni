using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder text = new StringBuilder("Write a program to demonstrate that your new extension methods work correctly.");
        IEnumerable<double> doubles = new List<double>() { 5.3, 2.5, 4.23 };

        string substr = text.Substring(8, 7);
        Console.WriteLine(substr);

        StringBuilder sb = new StringBuilder();
        sb = text.RemoveText("write ");
        Console.WriteLine(sb);

        StringBuilder sbAppend = new StringBuilder();
        sbAppend = text.AppendAll(doubles);
        Console.WriteLine(sbAppend);
    }
}
