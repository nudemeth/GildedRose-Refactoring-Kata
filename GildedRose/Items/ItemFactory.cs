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
                "Aged Brie" => new AgedBrie(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackStagePasses(item),
                "Sulfuras, Hand of Ragnaros" => new Sulfuras(item),
                _ => new NormalItem(item),
            };
        }
    }
}
