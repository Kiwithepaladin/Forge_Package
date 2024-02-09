using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crafting.API.Impl.Stat
{
    /// <summary>
    /// This IStatSheet implementation auto populates the hashset with basic assembly reflection
    /// </summary>
    public sealed class StatsSheet : IStatSheet
    {
        public HashSet<IStat> Stats { get; set; }
        
        public StatsSheet()
        {
            Stats = new();
            foreach (Type statType in AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IStat).IsAssignableFrom(p)))
            {
                if (statType.IsInterface || statType.IsAbstract)
                {
                    continue;
                }

                var newStat = Activator.CreateInstance(statType);
                Stats.Add((IStat)newStat);
            }
        }
    }
}
