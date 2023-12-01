using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public abstract class NumericStat : IStat
    {
        public abstract float MAX_VALUE { get; }
        public abstract float WEIGHT { get; }
        public float Value { get; private set; }

        public NumericStat(float initValue = 100)
        {
            Value = initValue;
        }

        public float Percentage()
        {
            return (Value / MAX_VALUE) * 100;
        }

        public void SetValue(float initValue)
        {
            if (initValue > MAX_VALUE)
            {
                initValue = MAX_VALUE;
            }

            Value = initValue;
        }
    }
}
