using Crafting.Core.Stat;
using System;

namespace Crafting.Core.Talents
{
    public interface ITalent<T> : ITalent where T : IStat
    {
        public Type StatType => typeof(T);
    }
}
