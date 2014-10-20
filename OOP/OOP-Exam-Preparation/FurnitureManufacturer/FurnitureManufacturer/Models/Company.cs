using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Company name cannot be null.");
                }

                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("value", "Company name must be at least 5 symbols.");
                }

                this.name = value;
            }
        }


        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("value", "Company registration number must be 10 symbols.");
                }
                if (!value.All(Char.IsDigit))
                {
                    throw new ArgumentException("All symbols in the registration number must be digits.");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(this.furnitures); }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture cannot be null.");
            }

            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture cannot be null.");
            }

            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.Furnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }

            return null;
        }

        public string Catalog()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format(
            "{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count == 1 ? "furniture" : "furnitures"));

            var sortedFurnitures = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            foreach (var furniture in sortedFurnitures)
            {
                output.AppendLine(furniture.ToString());
            }

            return output.ToString().Trim();
        }
    }
}
