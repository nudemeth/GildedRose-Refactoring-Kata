using GildedRoseKata.Depreciation;
using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class BackStagePasses : NormalItem
    {
        public BackStagePasses(Item item) : base(item)
        {
        }

        public override IDepreciationRate DepreciationRate => new StepDepreciationRate(new SortedDictionary<int, int> { { 10, 2 }, { 5, 3 } });

        public override void UpdateQuality()
        {
            Item.Quality = DepreciationRate.CalculateQuality(new NormalQuality(Item.Quality), Item.SellIn);
        }
    }
}
