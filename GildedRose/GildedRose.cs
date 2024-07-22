using GildedRoseKata.Items;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var itemV2 = ItemFactory.CreateItem(Items[i]);
            itemV2.UpdateSellIn();
            itemV2.UpdateQuality();
        }
    }
}