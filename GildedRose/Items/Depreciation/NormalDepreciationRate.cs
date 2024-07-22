using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class NormalDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(IQuality quality, int sellIn)
        {
            quality.Subtract(1);

            if (sellIn < 0)
            {
                quality.Subtract(1);
            }

            return quality.Value;
        }
    }
}
