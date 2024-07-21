using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items
{
    public class ItemFactory
    {
        public static IItem CreateItem(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new AgedBrie { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
                "Backstage passes to a TAFKAL80ETC concert" => new BackStagePasses { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
                _ => new NormalItem { Name = item.Name, SellIn = item.SellIn, Quality = item.Quality },
            };
        }
    }
}
