namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;

    public class Drink : Recipe, IDrink
    {
        private bool isCarbonated;
        public Drink(string initialName, decimal initialPrice, int initialCalories, 
            int initialQuantityPerServing, int initialTimeToPrepare, bool initialIsCarbonated)
            : base(initialName, initialPrice, initialCalories, initialQuantityPerServing, initialTimeToPrepare)
        {
            this.Unit = MetricUnit.Milliliters;
            CheckDrinkCalories(initialCalories);
            CheckDrinkTimeToPrepare(initialTimeToPrepare);

            this.IsCarbonated = initialIsCarbonated;
        }
        
        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }
            private set
            {
                this.isCarbonated = value;
            }
        }     
        
        private void CheckDrinkCalories(int calories)
        {
            if(calories > 100)
            {
                throw new ArgumentException("The calories in a drink must not be greater than 100.");
            }
        }

        private void CheckDrinkTimeToPrepare(int timeToPrepare)
        {
            if (timeToPrepare > 20)
            {
                throw new ArgumentException("The time to prepare a drink must not be greater than 20 minutes.");
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(base.ToString());
            // Carbonated: <yes / no>
            output.AppendLine(string.Format("Carbonated: {0}", this.IsCarbonated ? "yes" : "no"));
            return output.ToString();
        }
    }    
}
