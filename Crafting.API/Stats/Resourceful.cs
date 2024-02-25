﻿using Crafting.Core.Stat;
using System;

namespace Crafting.API.Stats
{
    public sealed class Resourceful : IStat<float>
    {
        public float MAX_VALUE => 100;
        float IStat<float>.value { get; set; }
        public Action<IStat> OnValueChanged { get; set; }
    }
}
