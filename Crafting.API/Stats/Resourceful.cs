using Crafting.Core.Stat;

namespace Crafting.API.Stats
{
    public sealed class Resourceful : IStat<float>
    {
        public float MAX_VALUE => 100;
        public float Value { get; set; }
    }
}
