using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class NormalItem : IItem
    {
        protected Item Item { get; }

        public NormalItem(Item item)
        {
            Item = item;
        }

        public virtual IDepreciationRate DepreciationRate => new NormalDepreciationRate();

        public virtual void UpdateQuality()
        {
            Item.Quality = DepreciationRate.CalculateQuality(Item.Quality, Item.SellIn);
        }

        public virtual void UpdateSellIn()
        {
            Item.SellIn--;
        }
    }
}
