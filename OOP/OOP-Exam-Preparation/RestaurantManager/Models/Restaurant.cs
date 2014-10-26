namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using RestaurantManager.Interfaces;

    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;

        public Restaurant(string initialName, string initialLocation)
        {
            this.Name = initialName;
            this.Location = initialLocation;
            this.recipes = new List<IRecipe>();
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

        public string Location
        {
            get
            {
                return this.location;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The location is required.");
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get
            {
                return new List<IRecipe>(this.recipes);
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException("Recipe cannot be null.");
            }

            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException("Recipe cannot be null.");
            }

            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            var output = new StringBuilder();
            output.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));
            if (this.Recipes.Count == 0)
            {
                output.Append("No recipes... yet");
            }

            //check for Drink
            bool isDrink = false;
            foreach (IRecipe recipe in this.recipes)
            {
                if (recipe is Drink)
                {
                    isDrink = true;
                    break;
                }
            }

            if (isDrink)
            {
                output.AppendLine("~~~~~ DRINKS ~~~~~");
                var drinksSorted = this.Recipes.OrderBy(d => d.Name);
                foreach (var drink in drinksSorted)
                {
                    if (drink is IDrink)
                    {
                        output.Append(drink.ToString());
                    }                    
                }
            }

            // check for Salad
            bool isSalad = false;
            foreach (IRecipe recipe in this.recipes)
            {
                if (recipe is ISalad)
                {
                    isSalad = true;
                    break;
                }
            }

            if (isSalad)
            {
                output.AppendLine("~~~~~ SALADS ~~~~~");
                var saladsSorted = this.Recipes.OrderBy(d => d.Name);
                foreach (var salad in saladsSorted)
                {
                    if (salad is ISalad)
                    {
                        output.Append(salad.ToString());
                    }
                }
            }

            // check for MainCourse
            bool isMainCourse = false;
            foreach (IRecipe recipe in this.recipes)
            {
                if (recipe is MainCourse)
                {
                    isMainCourse = true;
                    break;
                }
            }

            if (isMainCourse)
            {
                output.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                var drinksSorted = this.Recipes.OrderBy(d => d.Name);
                foreach (var mainCourse in drinksSorted)
                {
                    if (mainCourse is IMainCourse)
                    {
                        output.Append(mainCourse.ToString());
                    }
                }
            }

            // check for Dessert
            bool isDessert = false;
            foreach (IRecipe recipe in this.recipes)
            {
                if (recipe is IDessert)
                {
                    isDessert = true;
                    break;
                }
            }

            if (isDessert)
            {
                output.AppendLine("~~~~~ DESSERTS ~~~~~");
                var dessertsSorted = this.Recipes.OrderBy(d => d.Name);
                foreach (var dessert in dessertsSorted)
                {
                    if (dessert is IDessert)
                    {
                        output.Append(dessert.ToString());
                    }
                }
            }

            return output.ToString().Trim();
        }
    }
}
