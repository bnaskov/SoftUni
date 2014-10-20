using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private const string ConvertedState = "Converted";
        private const string NormalState = "Normal";

        private readonly decimal nonConvertedHeight;

        public ConvertibleChair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight, initialNumberOfLegs)
        {
            this.nonConvertedHeight = initialHeight;
        }
        public bool IsConverted { get; private set; }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.Height = this.nonConvertedHeight;
            }
            else
            {
                this.Height = 0.10M;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendFormat(", State: {0}", this.IsConverted ? ConvertedState : NormalState);
            return output.ToString();
        }
    }
}
