using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Data;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent<T> : ITalent where T : IStat
    {
        public Type StatType => typeof(T);
        public void Update(T stat);
    }
}
