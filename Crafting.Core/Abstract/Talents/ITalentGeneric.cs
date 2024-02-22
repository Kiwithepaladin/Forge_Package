using Crafting.Core.Abstract.Stat;
using System;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent<T> : ITalent where T : IStat
    {
        public Type StatType => typeof(T);
        public void ApplyPoints(int newPoints)
        {
            var value = Math.Clamp(CurrentPoints + newPoints, 0, MAX_POINTS);
            CurrentPoints = value;
        }
        public T Obtain();
    }
}
