﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Depreciation
{
    public class StepDepreciationRate : IDepreciationRate
    {
        private readonly SortedDictionary<int, int> _stepConfigs;

        public StepDepreciationRate(SortedDictionary<int, int> stepConfigs)
        {
            _stepConfigs = stepConfigs;
        }

        public int CalculateQuality(int quality, int sellIn)
        {
            if (sellIn <= 0)
            {
                return 0;
            }

            var newQuality = quality + 1;

            foreach (var (dueIn, step) in _stepConfigs)
            {
                if (sellIn <= dueIn)
                {
                    newQuality = quality + step;
                    break;
                }
            }

            if (newQuality > 50)
            {
                newQuality = 50;
            }

            return newQuality;
        }
    }
}
