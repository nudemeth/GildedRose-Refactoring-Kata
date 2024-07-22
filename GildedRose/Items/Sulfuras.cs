using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class Sulfuras : NormalItem
    {
        public Sulfuras(Item item) : base(item)
        {
        }

        public override IDepreciationRate DepreciationRate => new NoDepreciationRate();

        public override void UpdateQuality()
        {
            Item.Quality = DepreciationRate.CalculateQuality(Item.Quality, Item.SellIn);
        }

        public override void UpdateSellIn()
        {
            //Not for sell item.
        }
    }
}
