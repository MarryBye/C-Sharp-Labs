using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Day
    {

        private int day;
        private int year;
        private bool isLeapYear;
        private int[] daysInMonths = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

        public int GetDay() { return day; }

        public Day(int day, int year) {
            this.year = year;
            GetLeapYear();

            if (isLeapYear)
                daysInMonths[1] = 29;

            this.day = day % daysInMonths.Sum();
        }

        private void GetLeapYear() {
            isLeapYear = (year % 4 == 0 && year % 100 != 0 && year % 400 != 0);
        }

        public string GetDate()
        {
            int month = 1;
            int day = this.day;

            for (int i = 0; i < daysInMonths.Length; i++)
            {
                if (day > daysInMonths[i])
                {
                    day -= daysInMonths[i];
                    month++;
                } else
                {
                    break;
                }
            }

            return $"{day}.{month}.{year}";
        }

    }
}
