using Crafting.Core.Abstract.Stat;
using Crafting.Core.Talents;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.API.Talents
{
    /// <summary>
    /// Implements ITalentTree, Automatically populates based on the Crafter Talent being the root 
    /// </summary>
    public sealed class TalentTree : ITalentTree
    {
        public string Name => nameof(TalentTree);
        public HashSet<ITalent> Talents { get; private set; }

        public TalentTree()
        {
            Talents = new();
            this.ConstructFromRootTalent(new Crafter());
        }
    }
}
