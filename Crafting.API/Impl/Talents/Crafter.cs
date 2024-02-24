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

        //TODO - this syntax is quite iffy, and might require a change in future release
        private readonly WeaponCrafter rightTalent = new();
        public ITalent Left => null;
        public ITalent Right => rightTalent;
        Action<ITalent> ITalent.OnUnlock { get; set; } = delegate { };
        private const bool ROOT_ALWAYS_TRUE = true;
        bool ITalent.accessible
        {
            get => ROOT_ALWAYS_TRUE;
            set
            {;
            }
        }
    }
}
