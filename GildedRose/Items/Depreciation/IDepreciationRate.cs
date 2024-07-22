﻿using GildedRoseKata.Items.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public interface IDepreciationRate
    {
        public int CalculateQuality(IQuality quality, int sellIn);
    }
}
