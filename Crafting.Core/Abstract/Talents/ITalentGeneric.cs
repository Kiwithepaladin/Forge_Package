using Crafting.Core.Abstract.Stat;
using System;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent<T> : ITalent where T : IStat
    {
        public Type StatType => typeof(T);
    }
}
