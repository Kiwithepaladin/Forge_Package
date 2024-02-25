using Crafting.Core.Stat;
using System;

namespace Crafting.API.Stats
{
    public sealed class Knowledge : IStat<int>
    {
        public int MAX_VALUE => 100;
        int IStat<int>.value { get; set; }
        public Action<IStat> OnValueChanged { get; set; }
    }
}
