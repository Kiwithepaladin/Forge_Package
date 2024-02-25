using System;

namespace Crafting.Core.Stat
{
    public interface IStat<T> : IStat
    {
        public abstract T MAX_VALUE { get; }
        public T Value { get; set; }
    }
}
