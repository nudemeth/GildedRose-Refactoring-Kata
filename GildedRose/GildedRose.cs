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
            var item = ItemFactory.CreateItem(Items[i]);
            item.UpdateSellIn();
            item.UpdateQuality();
        }
    }
}