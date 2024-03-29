﻿using Crafting.API.Stats;
using Crafting.Core.Talents;
using System;

namespace Crafting.API.Talents
{
    public sealed class WeaponCrafter : ITalent<Knowledge>
    {
        public string Name => nameof(WeaponCrafter);
        public string Description => "An Example Talent Point For Weapon Crafter Talent";
        public int MAX_POINTS { get => 2; }
        int ITalent.currentPoints { get; set; }
        private readonly SpearCrafter leftTalent = new();
        private readonly SwordCrafter rightTalent = new();
        public ITalent Left => leftTalent;
        public ITalent Right => rightTalent;
        Action<ITalent> ITalent.OnUnlock { get; set; } = delegate { };
        bool ITalent.accessible { get; set; }
    }
}
