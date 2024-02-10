using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Teapot : Electronics, Loadable
    {
        private double maxLoad;
        private double maxWeight;

        private string model;

        public Teapot()
        {
            price = 0;
            amount = 0;
            unit = Units.PACKAGE;
            name = "N/D";
            energySavingClass = EnergyClass.APP;
            maxLoad = 0;
            model = "N/D";
        }

        public Teapot(int price, int amount, string name, string model, int maxLoad, EnergyClass energySavingClass)
        {
            this.price = price;
            this.amount = amount;
            unit = Units.PACKAGE;
            this.name = name;
            this.energySavingClass = energySavingClass;
            this.maxLoad = maxLoad;
            this.model = model;
        }

        public double GetMaxLoad()
        {
            return maxLoad;
        }

        public double GetMaxWeight()
        {
            return maxWeight;
        }

        public override string getDescription()
        {
            return $"{name} {model} клас енергосбережения: {energySavingClass}, объем: {maxLoad} л.";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(96);

            sb.Append($"{name} {model} / стоимость: {price} р. / остаток: {amount} {unit}");

            return sb.ToString();
        }
    }
}
