using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.area = this.Height * this.Width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Table length cannot be negative or equal to zeto.");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Table width cannot be negative or equal to zeto.");
                }

                this.width = value;
            }
        }

        public decimal Area
        {
            get { return this.area; }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendFormat(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
            return output.ToString();
        }
    }
}
