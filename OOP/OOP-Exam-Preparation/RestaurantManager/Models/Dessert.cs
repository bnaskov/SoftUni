namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class Dessert : Meal, IDessert
    {
        private bool withSugar;

        public Dessert(string initialName, decimal initialPrice, int initialCalories,
            int initialQuantityPerServing, int initialTimeToPrepare, bool initialIsVegan)
            : base(initialName, initialPrice, initialCalories, initialQuantityPerServing, 
            initialTimeToPrepare, initialIsVegan)
        {
            this.withSugar = true;
        }

        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }
        }

        public void ToggleSugar()
        {
            this.withSugar = !this.withSugar;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            // [NO SUGAR] 
            if (!this.WithSugar)
            {
                output.Append("[NO SUGAR] ");
            }
            if (this.IsVegan)
            {
                output.Append("[VEGAN] ");
            }
            output.Append(base.ToString());

            return output.ToString();
        }
    }
}
