using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Knowledge : IStat<int>
    {
        public int MAX_VALUE => 100;
        public int Value { get; set; }
    }
}
