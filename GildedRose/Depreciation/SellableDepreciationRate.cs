using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public abstract class SellableDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(int quality, int sellIn)
        {
            var newQuality = Calculate(quality, sellIn);
            return ApplyLimit(newQuality);
        }

        protected virtual int ApplyLimit(int quality)
        {
            if (quality < 0)
            {
                return 0;
            }

            if (quality > 50)
            {
                return 50;
            }

            return quality;
        }

        protected abstract int Calculate(int quality, int sellIn);
    }
}
