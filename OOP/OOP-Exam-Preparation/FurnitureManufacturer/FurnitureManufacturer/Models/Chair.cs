using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Chair : Furniture, IChair
    {
        public Chair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight)
        {
            this.NumberOfLegs = initialNumberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendFormat(", Legs: {0}", this.NumberOfLegs);
            return output.ToString();
        }
    }
}
