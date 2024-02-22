using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalentTree
    {
        public string Name { get; }
        public HashSet<ITalent> Talents { get; }
    }
}
