using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items.Qualities
{
    public class LegendaryQuality : IQuality
    {
        public LegendaryQuality(int quality)
        {
            Value = quality;
        }

        public int Value { get; private set; }

        public void Add(int quality)
        {
        }

        public void Subtract(int quality)
        {
        }
    }
}
