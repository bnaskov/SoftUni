using System;

class Demo
{

    public static void writeSeconds(string str)
    {
        Console.WriteLine(str);
    }

    static void Main()
    {
        AsyncTimer timer = new AsyncTimer(writeSeconds, 500, 20);
        timer.Start();
    }
}
