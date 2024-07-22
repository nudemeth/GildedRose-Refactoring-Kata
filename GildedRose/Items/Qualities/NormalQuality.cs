using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items.Qualities
{
    public class NormalQuality : IQuality
    {
        public NormalQuality(int quality)
        {
            Value = quality;
        }

        public int Value { get; private set; }

        public void Add(int quality)
        {
            Value += quality;

            if (Value > 50)
            {
                Value = 50;
            }
        }

        public void Subtract(int quality)
        {
            Value -= quality;

            if (Value < 0)
            {
                Value = 0;
            }
        }
    }
}
