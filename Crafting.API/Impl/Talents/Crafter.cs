using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Abstract.Talents;
using Crafting.Core.Utility;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class Crafter : ITalent<Knowledge>
    {
        public string Name => nameof(Crafter);
        public string Description => "An Example Talent Point For Crafter Talent";
        public int MAX_POINTS { get => 1; }
        int ITalent. currentPoints { get; set; }
        public ITalent Left => null;
        public ITalent Right => new WeaponCrafter();
        Action<ITalent> ITalent.OnUnlock { get; set; } = delegate { };
    }
}
