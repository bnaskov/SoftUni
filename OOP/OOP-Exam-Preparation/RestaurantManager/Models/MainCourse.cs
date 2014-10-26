namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class MainCourse : Meal, IMainCourse
    {
        private MainCourseType type;

        public MainCourse(string initialName, decimal initialPrice, int initialCalories,
            int initialQuantityPerServing, int initialTimeToPrepare, bool initialIsVegan, MainCourseType initialType)
            : base(initialName, initialPrice, initialCalories, initialQuantityPerServing, initialTimeToPrepare, initialIsVegan)
        {
            this.Type = initialType;           
        }

        public MainCourseType Type
        {
            get 
            { 
                return this.type; 
            }
            private set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            if (this.IsVegan)
            {
                output.Append("[VEGAN] ");
            }
            output.Append(base.ToString());
            // Type: <type>
            output.AppendLine(string.Format("Type: {0}", this.Type.ToString()));
            return output.ToString();
        }
    }
}
