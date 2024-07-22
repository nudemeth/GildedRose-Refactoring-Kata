using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class Sulfuras : Item, IItem
    {
        public IDepreciationRate DepreciationRate => new NoDepreciationRate();

        public void UpdateQuality()
        {
            Quality = DepreciationRate.CalculateQuality(Quality, SellIn);
        }

        public void UpdateSellIn()
        {
            //Not for sell item.
        }
    }
}
