namespace _02_Human_Student_Worker
{
    using System;

    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.moneyPerHour = GetMoneyPerHour();
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be zero or negative!", "WeekSalary");
                } 

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (value <= 0 || value > 24)
                {
                    throw new ArgumentException("Work hours cannot be negative ot more than 24!", "WorkHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour
        {
            get { return this.moneyPerHour; }

            private set
            {

            }
        }

        public decimal GetMoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / (5 * this.workHoursPerDay);
            return moneyPerHour;
        }
    }

}


