using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public interface IStatSheet
    {
        public HashSet<IStat> Stats { get; set; }
    }
}
