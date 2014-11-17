using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task2
{
    class Task2
    {
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                action();
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main()
        {
            float numFloat = 1.0f;
            double sum = 0;

            Console.Write("Float square: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sqrt((double)numFloat);
                }
            });

            Console.Write("Float log: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Log((double)numFloat);
                }
            });

            Console.Write("Float sinus: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sin((double)numFloat);
                }
            });

            double numDouble = 1.0d;
            sum = 0;

            Console.Write("Double square: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sqrt(numDouble);
                }
            });

            Console.Write("Double log: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Log(numDouble);
                }
            });

            Console.Write("Double sinus: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sin(numDouble);
                }
            });

            decimal numDecimal = 1.0M;
            sum = 0;

            Console.Write("Decimal sqr: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sqrt((double)numDecimal);
                }
            });

            Console.Write("Decimal log: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Log((double)numDecimal);
                }
            });

            Console.Write("Decimal sinus: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 1; i <= 100000; i++)
                {
                    sum += Math.Sin((double)numDecimal);
                }
            });
        }
    }
}
