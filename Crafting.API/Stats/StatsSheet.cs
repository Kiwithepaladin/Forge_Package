using Crafting.Core.Stat;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crafting.API.Stats
{
    /// <summary>
    /// Implements IStatSheet and auto populates the hashset using IStats from the assembly
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

                IStat newStat = (IStat)Activator.CreateInstance(statType);
                Stats.Add(newStat);
            }
        }
    }
}
