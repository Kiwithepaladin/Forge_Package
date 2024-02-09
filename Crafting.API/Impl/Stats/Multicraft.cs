using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Multicraft : IStat<float>
    {
        public float MAX_VALUE => 100;
        public float Value { get; set; }
        public static int MAX_MULTICRAFT => 4;

        public void SetValue(float newValue)
        {
            Value = newValue;
        }
    }
}
