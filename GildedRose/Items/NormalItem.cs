using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    internal class NormalItem : Item, IItem
    {
        public IDepreciationRate DepreciationRate => new NormalDepreciationRate();

        public void UpdateQuality()
        {
            Quality = DepreciationRate.CalculateQuality(Quality, SellIn);
        }

        public void UpdateSellIn()
        {
            --SellIn;
        }
    }
}
