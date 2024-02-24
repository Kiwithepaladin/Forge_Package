using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Inspiration : IStat<bool>
    {
        public bool MAX_VALUE => true;
        public bool Value { get; set; }
    }
}
