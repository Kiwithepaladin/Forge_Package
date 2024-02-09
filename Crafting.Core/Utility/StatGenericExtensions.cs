using Crafting.Core.Abstract.Stat;

namespace Crafting.Core.Utility
{
    public static class StatGenericExtensions
    {
        public static float Percentage(this IStat<float> stat)
        {
            return (stat.Value / stat.MAX_VALUE) * 100;
        }
    }
}
