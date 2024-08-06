using GildedRoseKata.Depreciation;
using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items.Depreciation
{
    public class LinearDepreciationRate : IDepreciationRate
    {
        private readonly int _slope;

        public LinearDepreciationRate(int slope)
        {
            _slope = slope;
        }

        public int CalculateQuality(IQuality quality, int sellIn)
        {
            quality.Subtract(_slope);

            if (sellIn < 0)
            {
                quality.Subtract(_slope);
            }

            return quality.Value;
        }
    }
}
