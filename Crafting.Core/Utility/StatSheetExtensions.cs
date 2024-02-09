using Crafting.Core.Abstract.Stat;
using System.Linq;

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
