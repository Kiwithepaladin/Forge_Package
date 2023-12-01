using Crafting.Core.Abstract.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.Core.Utility
{
    public static class StatSheetExtensions
    {
        public static T GetStat<T>(this IStatSheet statSheet) where T : IStat
        {
            return (T)statSheet.Stats.First((s) => s.GetType() == typeof(T));
        }
    }
}
