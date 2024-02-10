using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Generator
    {
        private int a, b, c;
        private int k_start = 1;
        private int k_now = 1;

        public int GetLast() { return k_now; }

        public int GetPred() { return k_start; }

        public Generator(int a, int b, int c, int k_start) {
            this.a = a; 
            this.b = b; 
            this.c = c;
            this.k_start = k_start;
        }

        public int GenerateNext()
        {

            k_now = (a * k_start + b) % c;
            k_start = k_now;

            return k_now;
        }

        public int[] GenerateArray(int length)
        {
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = GenerateNext();
            }

            return numbers;
        }

    }
}
