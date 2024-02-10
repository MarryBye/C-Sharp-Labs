using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class GeneratorFib
    {
        private int a = 1;
        private int b = 1;
        private List<double> start_numbers = new List<double>();

        public GeneratorFib(int a, int b) {
            this.a = a; 
            this.b = b;

            var rand = new Random();
            for (int i = 0; i <= Math.Max(a, b); i++) {
                start_numbers.Add(Math.Round(rand.NextDouble(), 1));
            }

        }

        public double GenerateNext()
        {
            int num_pos = start_numbers.Count();
            double next_num = 0.0;
            double k1 = start_numbers[num_pos - a];
            double k2 = start_numbers[num_pos - b];

            if (k1 >= k2) {
                next_num = k1 - k2;
            } else
            {
                next_num = k1 - k2 + 1;
            }

            next_num = Math.Round(next_num, 1);

            start_numbers.Add(next_num);
            return next_num;
        }

        public double[] GenerateArray(int length)
        {
            double[] numbers = new double[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = GenerateNext();
            }

            return numbers;
        }

    }
}
