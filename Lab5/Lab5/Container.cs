using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Container
    {

        protected List<Balloon> balloons = new List<Balloon>();

        public int BalloonsCount() => balloons.Count();

        public void ClearBalloons() => balloons.Clear();

        public bool HasBalloon(Balloon balloon) => balloons.Contains(balloon);

        public void SortBalloons()
        {
            int length = BalloonsCount();
            Balloon temp;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (balloons[j].Size() > balloons[j + 1].Size())
                    {
                        temp = balloons[j + 1];
                        balloons[j + 1] = balloons[j];
                        balloons[j] = temp;
                    }
                }
            }
        }

        public virtual void AddBalloon(Balloon balloon)
        {
            if (!HasBalloon(balloon))
                balloons.Add(balloon);
        }

        public void RemoveBalloon(Balloon balloon)
        {
            if (HasBalloon(balloon)) 
                balloons.Remove(balloon);
        }

        public int BalloonsSizeSum()
        {
            int size = 0;
            for (int i = 0; i < BalloonsCount(); i++)
                size += balloons[i].Size();
            return size;
        }

        public override string ToString()
        {
            SortBalloons();
            string text = "";
            for (int i = 0; i < BalloonsCount(); i++)
            {
                text += $"Ballon #{i + 1} | Size {balloons[i].Size()}\n";
            }
            return text;
        }
    }
}
