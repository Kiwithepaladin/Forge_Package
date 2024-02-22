﻿using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class SwordMaster : ITalent<Knowledge>
    {
        public string Name => nameof(SwordMaster);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Sword Master Talent";

        public ITalent Left => new SpearMaster();

        public ITalent Right => null;

        public void Update(Knowledge stat)
        {
            stat.Value = 10;
        }
    }
}
