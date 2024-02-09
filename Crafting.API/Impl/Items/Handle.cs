using Crafting.Core.Abstract.Components;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Items
{
    public sealed class Handle : Item
    {
        public override string Name => nameof(Handle);
        public override Difficulty Difficulty { get => Difficulty.Easy; }
    }
}

