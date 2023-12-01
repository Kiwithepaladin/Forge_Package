using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Stat
{
    public interface IStatSheet
    {
        public List<IStat> Stats { get; set; }
    }
}
