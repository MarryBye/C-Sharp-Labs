using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal abstract class Product
    {

        protected int price;
        protected int amount;
        protected Units unit;

        protected string name;

        public Product() { 
            price = 0;
            amount = 0;
            unit = Units.KILOGRAMS;
            name = "N/D";
        }

        public Product(int price, int amount, Units unit, string name)
        {
            this.price = price;
            this.amount = amount;
            this.unit = unit;
            this.name = name;
        }

        public bool isAvailable(double amount) { 
            return this.amount >= amount; 
        }
        public int canBuyAmount(double moneyAmount) { 
            return Convert.ToInt32(moneyAmount / Convert.ToDouble(price)); 
        }
        public int canBuyAmount(double moneyAmount, int discount) {
            double new_price = price - (discount * price / 100);
            return Convert.ToInt32(moneyAmount / new_price);
        }
        public abstract String getDescription();
    }
}
