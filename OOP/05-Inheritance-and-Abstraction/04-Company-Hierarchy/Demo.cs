namespace CompanyHierarchy.Hierarchy
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {            
            Sales books = new Sales("JavaProgramming", new DateTime(2013,5,2), 19.90m);
            Sales beer = new Sales("Ariana", new DateTime(2014,10,3), 1.25m);
            Sales whiskey = new Sales("Jameson", new DateTime(2014,10,3), 29.50m);
            Sales milk = new Sales("Verea", new DateTime(2014, 10, 1), 2.50m);
            Sales chocolate = new Sales("Milka", new DateTime(2014, 10, 1), 1.80m);
            Sales meat = new Sales("Meat", new DateTime(2014, 10, 1), 4.80m);
            Sales vegitables = new Sales("Potatoes", new DateTime(2014, 10, 1), 2.80m);
            Sales laptop = new Sales("Lenovo Yoga", new DateTime(2014, 10, 2), 1280.00m);

            var foodSales = new List<Sales>();
            foodSales.Add(milk);
            foodSales.Add(chocolate);
            foodSales.Add(vegitables);

            var otherSales = new List<Sales>();
            otherSales.Add(books);
            otherSales.Add(laptop);
            otherSales.Add(beer);
            otherSales.Add(whiskey);
            
            Project CSharp = new Project("Accounting system", new DateTime(2014,9,15), "N/A");
            Project Java = new Project("Booking system", new DateTime(2014,5,13), "N/A");
            Project PHP = new Project("Database Center", new DateTime(2014,8,20), "N/A");
            Project JavaScript = new Project("Video games", new DateTime(2014,7,28), "N/A");
            Project HTML_CSS = new Project("Military web-site", new DateTime(2014,8,8), "N/A");

            var webPoejcts = new List<Project>();
            webPoejcts.Add(HTML_CSS);
            webPoejcts.Add(JavaScript);
            webPoejcts.Add(Java);

            var otherProjects = new List<Project>();
            otherProjects.Add(CSharp);
            otherProjects.Add(PHP);

            RegularEmployee foodSalesEmployee = new SalesEmployee("Ivan","Ivanov", 100, 1000, Department.Sales,foodSales);
            RegularEmployee othersSalesEmployee = new SalesEmployee("Jon","Snow", 97, 1400, Department.Sales,otherSales);

            RegularEmployee webDeveloper = new Developer("Sansa", "Stark", 333, 1800, Department.Marketing, webPoejcts);
            RegularEmployee appDevelooper = new Developer("Tyrion", "Lannister", 666, 2800, Department.Production, otherProjects);

            var otherEmployees = new List<Employee>();
            otherEmployees.Add(foodSalesEmployee);
            otherEmployees.Add(othersSalesEmployee);

            var programmerEmployees = new List<Employee>();
            programmerEmployees.Add(webDeveloper);
            programmerEmployees.Add(appDevelooper);

            Employee programmingManager = new Manager("Daenerys", "Targaryen", 111, 8000, Department.Sales, programmerEmployees);
            Employee accountingManager = new Manager("Jaime", "Lannister", 221, 2000, Department.Accounting, otherEmployees);

            var managers = new List<Person>();
            managers.Add(programmingManager);
            managers.Add(accountingManager);

            foreach (var manager in managers)
            {
                Console.WriteLine(manager);
            }
        }
    }
}
