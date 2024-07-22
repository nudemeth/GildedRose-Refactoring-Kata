using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Items.Qualities
{
    public interface IQuality
    {
        public int Value { get; }

        public void Add(int quality);

        public void Subtract(int quality);
    }
}
