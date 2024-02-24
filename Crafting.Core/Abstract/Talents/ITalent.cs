using System;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent
    {
        public string Name { get; }
        public string Description { get; }
        public int MAX_POINTS { get; }
        protected int CurrentPoints { get; set; }
        public bool Unlocked {  get => CurrentPoints >= MAX_POINTS; }
        public Action<ITalent> OnUnlock { get; set; }
        public ITalent Left { get; }
        public ITalent Right { get; }

        public void ApplyPoints(int newPoints)
        {
            if (CurrentPoints >= MAX_POINTS)
            {
                return;
            }

            var value = Math.Clamp(CurrentPoints + newPoints, 0, MAX_POINTS);
            CurrentPoints = value;

            if (Unlocked)
            {
                OnUnlock?.Invoke(this);
            }
        }
    }
}
