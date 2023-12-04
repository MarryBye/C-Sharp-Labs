using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Box : Container
    {
        private int size;

        public int Size() => size;

        public Box(int size)
        {
            this.size = size;
        }

        public override void AddBalloon(Balloon balloon)
        {
            if (!HasBalloon(balloon) && (BalloonsCount() < Size()))
                balloons.Add(balloon);
        }

    }
}
