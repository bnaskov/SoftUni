namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;

    public class Salad : Meal, ISalad
    {
        private const bool IsVeganConst = true;

        private bool containsPasta;       

        public Salad(string initialName, decimal initialPrice, int initialCalories,
            int initialQuantityPerServing, int initialTimeToPrepare, bool initialContainsPasta)
            : base(initialName, initialPrice, initialCalories, initialQuantityPerServing, initialTimeToPrepare, IsVeganConst)
        {
            this.containsPasta = initialContainsPasta;
        }

        public bool ContainsPasta
        {
            get 
            { 
                return this.containsPasta; 
            }
            private set
            {
                this.containsPasta = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append("[VEGAN] ");
            output.Append(base.ToString());
            // Contains pasta: <yes / no>
            output.AppendLine(string.Format("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no"));
            return output.ToString();
        }
    }
}
