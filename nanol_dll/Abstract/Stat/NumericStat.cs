using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public abstract class NumericStat : IStat
    {
        public abstract float MAX_VALUE { get; }
        public abstract float WEIGHT { get; }

        public readonly float value;

        public NumericStat(float initValue = 300)
        {
            value = initValue;
        }

        public float Percentage()
        {
            return value / MAX_VALUE;
        }
    }
}
