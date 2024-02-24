using System;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent
    {
        public string Name { get; }
        public string Description { get; }
        public int MAX_POINTS { get; }
        protected int currentPoints { get; set; }
        public int CurrentPoints => currentPoints;
        public bool Unlocked {  get => currentPoints >= MAX_POINTS; }
        public Action<ITalent> OnUnlock { get; set; }
        public ITalent Left { get; }
        public ITalent Right { get; }

        public void ApplyPoints(int newPoints)
        {
            if (currentPoints >= MAX_POINTS)
            {
                return;
            }

            var value = Math.Clamp(currentPoints + newPoints, 0, MAX_POINTS);
            currentPoints = value;

            if (Unlocked)
            {
                OnUnlock?.Invoke(this);
            }
        }
    }
}
