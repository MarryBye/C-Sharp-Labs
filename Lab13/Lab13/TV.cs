using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class TV : Electronics
    {
        Resolution max_resolution;
        string model;

        public TV()
        {
            price = 0;
            amount = 0;
            unit = Units.KILOGRAMS;
            name = "N/D";
            energySavingClass = EnergyClass.APP;
            max_resolution = Resolution.FHD;
            model = "N/D";
        }

        public TV(int price, int amount, Units unit, string name, string model, Resolution max_resolution, EnergyClass energySavingClass)
        {
            this.price = price;
            this.amount = amount;
            this.unit = unit;
            this.name = name;
            this.energySavingClass = energySavingClass;
            this.max_resolution = max_resolution;
            this.model = model;
        }

        public override string getDescription() 
        { 
            return $"{name} {model} клас енергозбереження: {energySavingClass} максимальне розширення екрану: {max_resolution}"; 
        }
    }
}
