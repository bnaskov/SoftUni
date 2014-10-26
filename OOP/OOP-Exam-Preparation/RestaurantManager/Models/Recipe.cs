namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using RestaurantManager.Interfaces;
    using System.Text;
    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private MetricUnit unit;

        public Recipe(string initialName, decimal initialPrice, int initialCalories, 
            int initialQuantityPerServing, int initialTimeToPrepare)
        {
            this.Name = initialName;
            this.Price = initialPrice;
            this.Calories = initialCalories;
            this.QuantityPerServing = initialQuantityPerServing;
            this.TimeToPrepare = initialTimeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is required.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price must be positive.");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get
            {
                return this.calories;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The calories must be positive.");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The quantityPerServing must be positive.");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }
            protected set
            {
                this.unit = value;
            }
        }

        public int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The timeToPrepare must be positive.");
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            //==  <name> == $<price>
            output.AppendLine(string.Format("==  {0} == ${1:0.00}",
                this.Name, this.Price));
            // Per serving: <quantity> <unit>, <calories> kcal
            string unitConverted = this.Unit.ToString() == "Grams" ? "g" : "ml";
            output.AppendLine(string.Format("Per serving: {0} {1}, {2} kcal",
                this.QuantityPerServing, unitConverted, this.Calories));
            // Ready in <time_to_prepare> minutes
            output.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            return output.ToString();
        }
    }
}
