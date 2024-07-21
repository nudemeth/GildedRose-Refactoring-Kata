using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class ReverseDepreciationRate : IDepreciationRate
    {
        public int CalculateQuality(int quality, int sellIn)
        {
            var newQuality = ++quality;

            if (newQuality > 50)
            {
                newQuality = 50;
            }

            return newQuality;
        }
    }
}
