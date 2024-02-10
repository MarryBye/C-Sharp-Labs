using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab14
{
    internal class Washer : Electronics, Loadable
    {

        private int maxRotations;
        private int programsCount;

        private double maxLoad;
        private double maxWeight;

        private string model;

        public Washer()
        {
            price = 0;
            amount = 0;
            unit = Units.PACKAGE;
            name = "N/D";
            energySavingClass = EnergyClass.APP;
            maxRotations = 0;
            programsCount = 0;
            maxWeight = 0;
            model = "N/D";
        }

        public Washer(int price, int amount, string name, string model, int maxRotations, int programsCount, int maxWeight, EnergyClass energySavingClass)
        {
            this.price = price;
            this.amount = amount;
            unit = Units.PACKAGE;
            this.name = name;
            this.energySavingClass = energySavingClass;
            this.maxRotations = maxRotations;
            this.programsCount = programsCount;
            this.maxWeight = maxWeight;
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
            return $"{name} {model} клас енергосбережения: {energySavingClass} {maxRotations} об/мин, {programsCount} программ, загрузка: {maxWeight} кг";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(96);

            sb.Append($"{name} {model} / стоимость: {price} р. / остаток: {amount} {unit}");

            return sb.ToString();
        }
    }
}
