using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class NoDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(IQuality quality, int sellIn)
        {
            return quality.Value;
        }
    }
}
