using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crafting.API.Impl.Stat
{
    /// <summary>
    /// This StatSheet class is auto generated from
    /// other classes that implement IStat
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
