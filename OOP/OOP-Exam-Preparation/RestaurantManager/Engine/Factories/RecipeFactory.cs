﻿namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using Models;

    public class RecipeFactory : IRecipeFactory
    {
        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            return new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            return new Salad(name, price, calories, quantityPerServing, timeToPrepare, containsPasta);
        }
        
        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {

            return new MainCourse(name, price, calories, quantityPerServing, timeToPrepare, isVegan, this.GetMainCourseType(type));
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            return new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan);
        }

        private MainCourseType GetMainCourseType(string type)
        {
            switch (type)
            {
                case "Soup":
                    return MainCourseType.Soup;
                case "Entree":
                    return MainCourseType.Entree;
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Side":
                    return MainCourseType.Side;
                case "Meat":
                    return MainCourseType.Meat;
                case "Other":
                    return MainCourseType.Other;
                default:
                    throw new ArgumentException("Invalid material type.");
            }
        }
    }
}
