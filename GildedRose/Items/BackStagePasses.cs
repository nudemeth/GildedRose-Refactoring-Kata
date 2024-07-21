using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class BackStagePasses : Item, IItem
    {
        public IDepreciationRate DepreciationRate => new StepDepreciationRate(new SortedDictionary<int, int> { { 10, 2 }, { 5, 3 } });

        public void UpdateQuality()
        {
            Quality = DepreciationRate.CalculateQuality(Quality, SellIn);
        }
    }
}
