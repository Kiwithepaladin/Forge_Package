using Crafting.Core.Abstract.Stat;
using System;
using System.Linq;

namespace Crafting.Core.Utility
{
    public static class StatSheetExtensions
    {
        public static T GetStat<T>(this IStatSheet statSheet) where T : IStat
        {
            var stat = (T)statSheet.Stats.First((s) => s.GetType() == typeof(T));
            
            if (stat != null)
            {
                return stat;
            }

            throw new InvalidOperationException();
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
