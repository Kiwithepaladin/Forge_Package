using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public interface IStat
    {
        public abstract float MAX_VALUE { get; }
        public abstract float WEIGHT { get; }
        public float Percentage();
    }
}
