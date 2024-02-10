using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО
// ПИСАЛ НОЧЬЮ И ХОТЕЛ СПАТЬ, СКОРЕЕ ВСЕГО КОСТЫЛЕЙ ОЧЕНЬ МНОГО

namespace Lab4
{
    internal class Fraction
    {
        private int sign; // знак дроби (+ или -)
        private int intPart; // целая часть дроби
        private int numerator; // числитель дроби
        private int denominator; // знаменатель дроби

        public Fraction(int sign = 1, int intPart = 0, int numerator = 0, int denominator = 1)
        {
            this.sign = sign;
            this.intPart = intPart;
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            GetMixedView();
            return $"{sign * intPart} {numerator}/{denominator}";
        }

        private void GetMixedView()
        {
            while (numerator >= denominator)
            {
                intPart++;
                numerator -= denominator;
            }
        }

        private void GetRationalView()
        {
            numerator += intPart * denominator;
            intPart = 0;
        }

        public void SetByDouble(int sign, double f)
        {
            int denominator = 1;

            while (f % 2 != 0)
            {
                f *= 10;
                denominator *= 10;
            }

            this.numerator = (int)f;
            this.denominator = denominator;
            this.sign = sign;
            this.intPart = 0;

            Cancellation();

        }

        public double ToDouble()
        {
            GetRationalView();

            double result = (double)numerator / denominator;
            return result;
        }

        public void Cancellation()
        {
            for (int i = 2; i < 10; i++) { 
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    i = 1;
                }
            }
            GetMixedView();
        }

        public void GetIntPart()
        {
            intPart = Convert.ToInt32(numerator / denominator);
        }

        public Fraction GetSum(Fraction f2) 
        {
            Fraction this_copy = new Fraction(sign, intPart, numerator, denominator);
            Fraction f2_copy = new Fraction(f2.sign, f2.intPart, f2.numerator, f2.denominator);

            this_copy.GetRationalView();
            f2_copy.GetRationalView();

            int f1_denom_buff = this_copy.denominator;
            int f2_denom_buff = f2_copy.denominator;

            this_copy.numerator *= f2_denom_buff;
            this_copy.denominator *= f2_denom_buff;

            f2_copy.numerator *= f1_denom_buff;
            f2_copy.denominator *= f1_denom_buff;

            int new_frac_numerator = (this_copy.sign * this_copy.numerator) + (f2_copy.sign * f2_copy.numerator);
            int new_frac_sign = (new_frac_numerator < 0) ? -1 : 1;
            new_frac_numerator *= new_frac_sign;

            Fraction new_frac = new Fraction(new_frac_sign, 0, new_frac_numerator, this_copy.denominator);
            new_frac.Cancellation();

            return new_frac;
        }

        public Fraction GetDiff(Fraction f2)
        {
            Fraction this_copy = new Fraction(sign, intPart, numerator, denominator);
            Fraction f2_copy = new Fraction(f2.sign, f2.intPart, f2.numerator, f2.denominator);

            this_copy.GetRationalView();
            f2_copy.GetRationalView();

            int f1_denom_buff = this_copy.denominator;
            int f2_denom_buff = f2_copy.denominator;

            this_copy.numerator *= f2_denom_buff;
            this_copy.denominator *= f2_denom_buff;

            f2_copy.numerator *= f1_denom_buff;
            f2_copy.denominator *= f1_denom_buff;

            int new_frac_numerator = (this_copy.sign * this_copy.numerator) - (f2_copy.sign * f2_copy.numerator);
            int new_frac_sign = (new_frac_numerator < 0) ? -1 : 1;
            new_frac_numerator *= new_frac_sign;

            Fraction new_frac = new Fraction(new_frac_sign, 0, new_frac_numerator, this_copy.denominator);
            new_frac.Cancellation();

            return new_frac;
        }

        public Fraction GetMult(Fraction f2)
        {

            Fraction this_copy = new Fraction(sign, intPart, numerator, denominator);
            Fraction f2_copy = new Fraction(f2.sign, f2.intPart, f2.numerator, f2.denominator);

            this_copy.GetRationalView();
            f2_copy.GetRationalView();

            int new_frac_numerator = (this_copy.numerator * this_copy.sign) * (f2_copy.numerator * f2_copy.sign);
            int new_frac_denominator = this_copy.denominator * f2_copy.denominator;
            int new_frac_sign = (new_frac_numerator < 0) ? -1 : 1;
            new_frac_numerator *= new_frac_sign;

            Fraction new_frac = new Fraction(new_frac_sign, 0, new_frac_numerator, new_frac_denominator);
            new_frac.Cancellation();

            return new_frac;
        }

        public Fraction GetQuot(Fraction f2)
        {
            Fraction this_copy = new Fraction(sign, intPart, numerator, denominator);
            Fraction f2_copy = new Fraction(f2.sign, f2.intPart, f2.numerator, f2.denominator);

            this_copy.GetRationalView();
            f2_copy.GetRationalView();

            int buff = f2_copy.numerator;
            f2_copy.numerator = f2.denominator;
            f2_copy.denominator = buff;

            int new_frac_numerator = (this_copy.numerator * this_copy.sign) * (f2_copy.numerator * f2_copy.sign);
            int new_frac_denominator = this_copy.denominator * f2_copy.denominator;
            int new_frac_sign = (new_frac_numerator < 0) ? -1 : 1;
            new_frac_numerator *= new_frac_sign;

            Fraction new_frac = new Fraction(new_frac_sign, 0, new_frac_numerator, new_frac_denominator);
            new_frac.Cancellation();

            return new_frac;
        }

    }
}

