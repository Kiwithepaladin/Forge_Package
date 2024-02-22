using Crafting.Core.Abstract.Stat;
using Crafting.Core.Abstract.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.API.Impl.Talents
{
    public sealed class TalentTree : ITalentTree
    {
        public string Name => nameof(TalentTree);
        public HashSet<ITalent> Talents => new();

        public void BuildTalentTree()
        {
            
        }
    }
}
