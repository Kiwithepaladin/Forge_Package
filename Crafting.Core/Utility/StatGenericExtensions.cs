using Crafting.Core.Stat;
using System;

namespace Crafting.Core.Utility
{
    public static class StatGenericExtensions
    {
        public static float Percentage(this IStat<float> stat)
        {
            return (stat.Value / stat.MAX_VALUE) * 100;
        }

        public static float Percentage(this IStat<int> stat)
        {
            return (stat.Value / stat.MAX_VALUE) * 100;
        }

        public static T Get<T>(this IStat<T> stat)
        {
            return stat.Value;
        }

        public static IStat<T> Set<T, J>(this IStat<T> stat, J value) where J : T
        {
            if (stat != null && stat is IStat<J>)
            {
                stat.Value = value;
                return stat;
            }
            else
            {
                throw new InvalidOperationException("Supplied Value does not match expected type");
            }
        }
    }
}
