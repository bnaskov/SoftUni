namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;

    public abstract class Meal : Recipe, IMeal
    {
        private bool isVegan;

        public Meal(string initialName, decimal initialPrice, int initialCalories,
            int initialQuantityPerServing, int initialTimeToPrepare, bool initialIsVegan)
            : base(initialName,initialPrice, initialCalories, initialQuantityPerServing, initialTimeToPrepare)
        {
            this.Unit = MetricUnit.Grams;
            this.IsVegan = initialIsVegan;
        }

        public bool IsVegan 
        {
            get 
            {
                return this.isVegan;
            }
            private set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            if (this.IsVegan)
            {
                this.IsVegan = false;
            }
            else
            {
                this.IsVegan = true;
            }
        }
    }
}
