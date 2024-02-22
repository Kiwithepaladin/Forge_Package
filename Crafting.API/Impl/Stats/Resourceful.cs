using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Resourceful : IStat<float>
    {
        public float MAX_VALUE => 100;
        public float Value { get; set; }
    }
}
