using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Knowledge : IStatGeneric<float>
    {
        public float MAX_VALUE => 100;
        public float Value { get; set; }

        public void SetValue(float newValue)
        {
            Value = newValue;
        }
    }
}
