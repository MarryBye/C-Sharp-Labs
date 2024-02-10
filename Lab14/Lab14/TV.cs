using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class TV : Electronics
    {
        private Resolution max_resolution;
        private string model;

        public TV()
        {
            price = 0;
            amount = 0;
            unit = Units.PACKAGE;
            name = "N/D";
            energySavingClass = EnergyClass.APP;
            max_resolution = Resolution.FHD;
            model = "N/D";
        }

        public TV(int price, int amount, string name, string model, Resolution max_resolution, EnergyClass energySavingClass)
        {
            this.price = price;
            this.amount = amount;
            unit = Units.PACKAGE;
            this.name = name;
            this.energySavingClass = energySavingClass;
            this.max_resolution = max_resolution;
            this.model = model;
        }

        public override string getDescription() 
        { 
            return $"{name} {model} клас енергозбереження: {energySavingClass} максимальне розширення екрану: {max_resolution}"; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(96);

            sb.Append($"{name} {model} / стоимость: {price} р. / остаток: {amount} {unit}");

            return sb.ToString();
        }
    }
}
