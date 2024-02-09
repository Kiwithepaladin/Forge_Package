using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public interface IStatGeneric<T> : IStat
    {
        public abstract T MAX_VALUE { get; }
        public T Value { get; }
        public void SetValue(T newValue);
    }
}
