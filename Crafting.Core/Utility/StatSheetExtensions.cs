using Crafting.Core.Abstract.Stat;
using System;
using System.Linq;

namespace Crafting.Core.Utility
{
    public static class StatSheetExtensions
    {
        //TODO - Add exception throwing if the stat is not found
        public static T GetStat<T>(this IStatSheet statSheet) where T : IStat
        {
            return (T)statSheet.Stats.First((s) => s.GetType() == typeof(T));
        }

        public static T SetStat<T, J>(this IStatSheet statSheet, J value) where T : IStat
        {
            if (GetStat<T>(statSheet) is IStat<J> stat)
            {
                stat.SetValue(value);
                return (T)stat;
            }

            throw new InvalidOperationException();
        }
    }
}
