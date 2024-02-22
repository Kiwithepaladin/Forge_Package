using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Talents
{
    public sealed class SwordMaster : ITalent<Knowledge>
    {
        public string Name => nameof(SwordMaster);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Sword Master Talent";

        public ITalent Left => throw new NotImplementedException();

        public ITalent Right => throw new NotImplementedException();

        public void Update(Knowledge stat)
        {
            stat.SetValue(10);
        }
    }
}
