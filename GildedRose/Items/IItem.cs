using GildedRoseKata.Depreciation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items;

public interface IItem
{
    public IDepreciationRate DepreciationRate { get; }

    public void UpdateQuality();

    public void UpdateSellIn();
}
