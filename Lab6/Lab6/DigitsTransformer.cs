using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class DigitsTransformer
    {
        private string digit;
        private int system_now;
        private Dictionary<char, int> digit_dict = new Dictionary<char, int>()
        {
            { 'A', 10 },
            { 'B', 11 },
            { 'C', 12 },
            { 'D', 13 },
            { 'E', 14 },
            { 'F', 15 },
        };

        private Dictionary<int, char> letter_dict = new Dictionary<int, char>()
        {
            { 10, 'A' },
            { 11, 'B' },
            { 12, 'C' },
            { 13, 'D' },
            { 14, 'E' },
            { 15, 'F' }
        };

        public string Digit() => digit;

        public int System_now() => system_now;

        public override string ToString() => $"Число: {digit} | Система: {system_now}";

        public DigitsTransformer(string digit, int system_now = 10)
        {
            this.digit = digit;
            this.system_now = system_now;
        }

        public string MakeNormal()
        {
            if (system_now == 10) return digit;

            char[] digit_copy_array = digit.ToCharArray();
            double new_digit = 0;
            int exponent = digit.Length - 1;

            for (int i = 0; i < digit.Length; i++)
            {
                char symbol_now = digit_copy_array[i];
                if (digit_dict.ContainsKey(symbol_now))
                {
                    new_digit += digit_dict[symbol_now] * Math.Pow(system_now, exponent);
                } else
                {
                    new_digit += int.Parse(symbol_now.ToString()) * Math.Pow(system_now, exponent);
                }
                exponent--;
            }

            system_now = 10;
            digit = Convert.ToString(new_digit);

            return digit;
        }

        public string TransformTo(int system)
        {

            if (system_now == system) return digit;

            MakeNormal();

            int digit_copy = Convert.ToInt32(digit);
            string new_digit = "";

            while (digit_copy > 0)
            {
                if (letter_dict.ContainsKey(digit_copy % system))
                {
                    new_digit += $"{letter_dict[digit_copy % system]}";
                } else
                {
                    new_digit += $"{digit_copy % system}";
                }
                digit_copy /= system;
            }

            char[] digit_array = new_digit.ToCharArray();

            Array.Reverse(digit_array);
            new_digit = new string(digit_array);

            system_now = system;
            digit = new_digit;

            return digit;
        }

    }
}
