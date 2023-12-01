using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Stats
{
    public sealed class Inspiration : NumericStat
    {
        public override float MAX_VALUE => 150;
        public override float WEIGHT => 20;
    }
}
