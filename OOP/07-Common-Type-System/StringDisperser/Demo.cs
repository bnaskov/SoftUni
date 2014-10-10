namespace StringDisperser
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        static void Main()
        {
            StringDisperser sDisp1 = new StringDisperser("Jon", "Snow", "Merry");
            StringDisperser sDisp2 = new StringDisperser("Jon", "Lanister", "Tyrion");
            StringDisperser sDisp3 = (StringDisperser)sDisp1.Clone();

            Console.WriteLine(sDisp1);

            Console.WriteLine(sDisp1 == sDisp2);
            Console.WriteLine(sDisp1 == sDisp3);

            foreach (var ch in sDisp1)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
