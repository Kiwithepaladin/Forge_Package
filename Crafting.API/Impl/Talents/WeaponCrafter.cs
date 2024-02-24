using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class WeaponCrafter : ITalent<Knowledge>
    {
        public string Name => nameof(WeaponCrafter);
        public string Description => "An Example Talent Point For Weapon Crafter Talent";
        public int MAX_POINTS { get => 2; }
        int ITalent.currentPoints { get; set; }
        private readonly SpearCrafter leftTalent = new();
        private readonly  SwordCrafter rightTalent = new();
        public ITalent Left => leftTalent;
        public ITalent Right => rightTalent;
        Action<ITalent> ITalent.OnUnlock { get; set; } = delegate { };
        bool ITalent.accessible { get; set; }
    }
}
