using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Operations_Performance_Tests
{
    class Task1
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
            int numInt = 0;

            Console.Write("Int add: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numInt += 1;
                }
            });

            Console.Write("Int substract: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numInt -= 1;
                }
            });

            Console.Write("Int increment: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numInt++;
                }
            });

            Console.Write("Int multiply: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numInt *= 1;
                }
            });

            Console.Write("Int divide: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numInt /= 1;
                }
            });

            ///
            long numLong = 0;

            Console.Write("Long add: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numLong += 1;
                }
            });

            Console.Write("Long substract: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numLong -= 1;
                }
            });

            Console.Write("Long increment: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numLong++;
                }
            });

            Console.Write("Long multiply: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numLong *= 1;
                }
            });

            Console.Write("Long divide: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numLong /= 1;
                }
            });


            float numFloat = 0.0f;

            Console.Write("Float add: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numFloat += 1;
                }
            });

            Console.Write("Float substract: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numFloat -= 1;
                }
            });

            Console.Write("Long increment: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numFloat++;
                }
            });

            Console.Write("Float multiply: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numFloat *= 1;
                }
            });

            Console.Write("Float divide: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numFloat /= 1;
                }
            });

            double numDouble = 0.0;

            Console.Write("Double add: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDouble += 1;
                }
            });

            Console.Write("Double substract: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDouble -= 1;
                }
            });

            Console.Write("Double increment: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDouble++;
                }
            });

            Console.Write("Double multiply: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDouble *= 1;
                }
            });

            Console.Write("Double divide: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDouble /= 1;
                }
            });

            decimal numDecimal = 0.0M;

            Console.Write("Decimal add: \t\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDecimal += 1m;
                }
            });

            Console.Write("Decimal substract: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDecimal -= 1m;
                }
            });

            Console.Write("Decimal increment: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDecimal++;
                }
            });

            Console.Write("Decimal multiply: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDecimal *= 1m;
                }
            });

            Console.Write("Decimal divide: \t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    numDecimal /= 1m;
                }
            });
        }
    }
}
