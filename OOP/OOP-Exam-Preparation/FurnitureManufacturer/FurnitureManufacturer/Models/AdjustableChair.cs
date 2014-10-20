using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string initialModel, MaterialType initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight, initialNumberOfLegs)
        {
        }
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
