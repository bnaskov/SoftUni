using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private readonly MaterialType materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.materialType = materialType;
            this.Price = price;
            this.Height = height;
        }
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value == null)
	            {
		             throw new ArgumentNullException("value", "Furniture model cannot be null.");
	            }

                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("value", "Model must be at least 3 symbols.");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get { return this.materialType.ToString(); }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Furniture price cannot be negative or equal to zeto.");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Furniture height cannot be negative or equal to zeto.");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
