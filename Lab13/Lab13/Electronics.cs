using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab13
{
    internal abstract class Electronics : Product
    {
        protected EnergyClass energySavingClass;

        public Electronics()
        {
            price = 0;
            amount = 0;
            unit = Units.KILOGRAMS;
            name = "N/D";
            energySavingClass = EnergyClass.APP;
        }

        public Electronics(int price, int amount, Units unit, string name, EnergyClass energySavingClass)
        {
            this.price = price;
            this.amount = amount;
            this.unit = unit;
            this.name = name;
            this.energySavingClass = energySavingClass;
        }
    }
}
