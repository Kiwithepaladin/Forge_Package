using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class SpearMaster : ITalent<Knowledge>
    {
        public string Name => nameof(SpearMaster);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Spear Master Talent";

        public ITalent Left => null;

        public ITalent Right => null;

        public void Update(Knowledge stat)
        {
            stat.Value = 10;
        }
    }
}
