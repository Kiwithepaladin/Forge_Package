using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class WeaponCrafter : ITalent<Knowledge>
    {
        public string Name => nameof(WeaponCrafter);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Weapon Crafter Talent";
        public int MAX_POINTS { get => 2; }
        public int CurrentPoints { get; }
        public ITalent Left => new SpearCrafter();
        public ITalent Right => new SwordCrafter();

        public void Update(Knowledge stat)
        {
            stat.Value = 10;
        }
    }
}
