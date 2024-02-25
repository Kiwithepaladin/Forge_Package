using Crafting.Core.Talents;
using Crafting.Core.Utility;
using System.Collections.Generic;

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
