using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Crafting.Core.Impl.Stat
{
    public sealed class StatsSheet
    {
        public List<IStat> Stats { get; private set; }

        public StatsSheet()
        {
            foreach (Type statType in AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IStat).IsAssignableFrom(p)))
            {
                var newStat = (IStat)Activator.CreateInstance(statType);
                Stats.Add(newStat);
            }
        }
    }
}
