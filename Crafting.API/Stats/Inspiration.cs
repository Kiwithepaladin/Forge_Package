using Crafting.Core.Stat;

namespace Crafting.API.Stats
{
    public sealed class Inspiration : IStat<bool>
    {
        public bool MAX_VALUE => true;
        public bool Value { get; set; }
    }
}
