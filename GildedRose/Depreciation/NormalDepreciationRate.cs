using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class NormalDepreciationRate : SellableDepreciationRate
    {
        protected override int Calculate(int quality, int sellIn)
        {
            var newQuality = quality - 1;

            if (sellIn < 0)
            {
                newQuality--;
            }

            return newQuality;
        }
    }
}
