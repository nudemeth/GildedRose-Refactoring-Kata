using GildedRoseKata.Items.Qualities;
using System;
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

        public int CalculateQuality(IQuality quality, int sellIn)
        {
            if (sellIn < 0)
            {
                return 0;
            }

            quality.Add(1);

            foreach (var (dueIn, step) in _stepConfigs)
            {
                if (sellIn < dueIn)
                {
                    quality.Subtract(1);
                    quality.Add(step);
                    break;
                }
            }

            return quality.Value;
        }
    }
}
