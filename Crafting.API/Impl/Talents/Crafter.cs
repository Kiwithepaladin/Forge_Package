﻿using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.API.Impl.Talents
{
    public sealed class Crafter : ITalent<Knowledge>
    {
        public string Name => nameof(Crafter);

        //TODO - write something here later
        public string Description => "An Example Talent Point For Crafter Talent";
        public int MAX_POINTS { get => 1; }
        public int CurrentPoints { get; }
        public ITalent Left => null;
        public ITalent Right => new WeaponCrafter();

        public void Update(Knowledge stat)
        {
            stat.Value = 10;
        }
    }
}
