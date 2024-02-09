using Crafting.Core.Abstract.Stat;

namespace Crafting.API.Impl.Stats
{
    public sealed class Multicraft : NumericStat
    {
        public override float MAX_VALUE => 100;
        public override float WEIGHT => 20;
        public static int MAX_MULTICRAFT => 4;
    }
}
