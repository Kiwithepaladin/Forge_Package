using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Multicraft : IStat<float>
    {
        public float MAX_VALUE => 100;
        public float Value { get; set; }
        public const int MAX_MULTICRAFT = 4;
    }
}
