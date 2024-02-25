using Crafting.API.Stats;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Talents;
using System;

namespace Crafting.API.Talents
{
    public sealed class SwordCrafter : ITalent<Knowledge>
    {
        public string Name => nameof(SwordCrafter);
        public string Description => "An Example Talent Point For Sword Crafter Talent";
        public int MAX_POINTS { get => 2; }
        int ITalent.currentPoints { get; set; }
        public ITalent Left => null;
        public ITalent Right => null;
        Action<ITalent> ITalent.OnUnlock { get; set; } = delegate { };
        bool ITalent.accessible { get; set; }
    }
}
