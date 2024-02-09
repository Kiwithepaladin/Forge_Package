using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Inspiration : IStat<bool>
    {
        public bool MAX_VALUE => true;
        public bool Value { get; private set; }

        public void SetValue(bool newValue)
        {
            Value = newValue;
        }
    }
}
