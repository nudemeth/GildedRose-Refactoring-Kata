using GildedRoseKata.Depreciation;
using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class AgedBrie : NormalItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        public override IDepreciationRate DepreciationRate => new ReverseDepreciationRate();

        public override void UpdateQuality()
        {
            Item.Quality = DepreciationRate.CalculateQuality(new NormalQuality(Item.Quality), Item.SellIn);
        }
    }
}
