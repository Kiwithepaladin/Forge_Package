using System;

namespace Crafting.Core.Stat
{
    public interface IStat<T> : IStat
    {
        public abstract T MAX_VALUE { get; }
        protected T value { get; set; }
        public T Value 
        { 
            get => value; 
            set
            {
                if (this.value == null || value == null)
                {
                    throw new ArgumentNullException($"Either the supplied value, or the internal value, is null");
                }

                if (!this.value.Equals(value))
                {
                    this.value = value;
                    OnValueChanged?.Invoke(this);
                }
            }
        }
    }
}
