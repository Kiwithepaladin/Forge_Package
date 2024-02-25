using Crafting.Core.Stat;

namespace Crafting.API.Stats
{
    public sealed class Knowledge : IStat<int>
    {
        public int MAX_VALUE => 100;
        public int Value { get; set; }
    }
}
