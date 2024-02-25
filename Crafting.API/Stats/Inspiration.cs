using Crafting.Core.Stat;
using System;

namespace Crafting.API.Stats
{
    public sealed class Inspiration : IStat<bool>
    {
        public bool MAX_VALUE => true;
        bool IStat<bool>.value { get; set; }
        public Action<IStat> OnValueChanged { get; set; }
    }
}