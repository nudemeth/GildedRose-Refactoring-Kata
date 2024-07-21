using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class AgedBrie : Item, IItem
    {
        public IDepreciationRate DepreciationRate => new ReverseDepreciationRate();

        public void UpdateQuality()
        {
            Quality = DepreciationRate.CalculateQuality(Quality, SellIn);
        }
    }
}
