using Crafting.Core.Abstract.Stat;
using Crafting.Core.Abstract.Talents;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.API.Impl.Talents
{
    /// <summary>
    /// Implements ITalentTree and automatically populates it based on the Crafter class being the root 
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
