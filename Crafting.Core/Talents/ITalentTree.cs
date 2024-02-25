using System.Collections.Generic;

namespace Crafting.Core.Talents
{
    public interface ITalentTree
    {
        public string Name { get; }
        public HashSet<ITalent> Talents { get; }
    }
}
