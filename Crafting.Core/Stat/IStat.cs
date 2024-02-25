using Crafting.Core.Components;
using System;
using System.Collections.Generic;

namespace Crafting.Core.Stat
{
    public interface IStat
    {
        public Action<IStat> OnValueChanged { get; set; }
    }
}
