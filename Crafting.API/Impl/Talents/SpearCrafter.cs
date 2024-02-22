using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class SpearCrafter : ITalent<Knowledge>
    {
        public string Name => nameof(SpearCrafter);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Spear Crafter Talent";
        public int MAX_POINTS { get => 2; }
        public int CurrentPoints { get; }
        public ITalent Left => null;
        public ITalent Right => null;

        public void Update(Knowledge stat)
        {
            stat.Value = 10;
        }
    }
}
