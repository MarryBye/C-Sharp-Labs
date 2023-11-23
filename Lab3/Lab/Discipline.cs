using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplineClass
{

    internal class Discipline
    {

        public string nameDisc;
        public int countLek;
        public int countLR;
        public int countSR;
        int TimeLek = 2;
        int TimeLR = 4;
        int TimeSR = 2;

        public Discipline()
        {
            nameDisc = "";
            countLek = 0;
            countLR = 0;
            countSR = 0;
        }

        public Discipline(string name, int lek, int lr, int sr)
        {
            nameDisc = name;
            countLek = lek;
            countLR = lr;
            countSR = sr;
        }

        public int Sum()
        {
            return countLek * TimeLek + countLR * TimeLR + countSR * TimeSR;
        }

    }

}
