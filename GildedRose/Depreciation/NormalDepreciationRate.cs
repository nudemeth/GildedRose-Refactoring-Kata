using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class NormalDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(int quality, int sellIn)
        {
            var newQuality = --quality;

            if (sellIn <= 0)
            {
                --newQuality;
            }

            if (newQuality < 0)
            {
                newQuality = 0;
            }

            return newQuality;
        }
    }
}
