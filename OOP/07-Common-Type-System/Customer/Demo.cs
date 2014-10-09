namespace Customer
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        static void Main()
        {
            IList<Payment> paymentsA = new List<Payment>()
            {
                new Payment("Utilities", 123.5m),
                new Payment("Groceries", 28.60m),
            };

            IList<Payment> paymentsB = new List<Payment>()
            {
                new Payment("Milk", 1.5m),
                new Payment("Bread", 1.1m),
                new Payment("Organge juice", 2.2m),
            };

            Customer ivan = new Customer("Ivan", "Ivanov", "Ivanov", "8910041276", "Ruse, 'Mladost', st. Vyzrajdane", 
                "0876112435", "ivan@snow.net", paymentsA, CustomerType.Regular);
            Customer george = new Customer("George", "Mikov", "Ivanov", "0010041276", "Sofia, 'Mladost', st. Vyzrajdane",
                "0889112090", "george@snow.net", paymentsB, CustomerType.Diamond);
            Customer ivanClone = (Customer)ivan.Clone();

            Console.WriteLine(ivan.ToString());
            Console.WriteLine(ivan.CompareTo(george));
            Console.WriteLine(ivan == george);
            Console.WriteLine();

            Console.WriteLine(ivanClone.ToString());
            Console.WriteLine(ivanClone.CompareTo(ivan));
            Console.WriteLine(ivanClone == ivan);
        }
    }
}
