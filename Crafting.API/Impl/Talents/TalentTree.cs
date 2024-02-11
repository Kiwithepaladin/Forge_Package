using Crafting.Core.Abstract.Talents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Talents
{
    public sealed class TalentTree : ITalentTree
    {
        public string Name => nameof(TalentTree);

        public HashSet<ITalent> Talents => throw new NotImplementedException();

        public void BuildTalentTree()
        {
            throw new NotImplementedException();
        }
    }
}
