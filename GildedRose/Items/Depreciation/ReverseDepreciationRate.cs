using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class ReverseDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(IQuality quality, int sellIn)
        {
            quality.Add(1);

            if (sellIn < 0)
            {
                quality.Add(1);
            }

            return quality.Value;
        }
    }
}
