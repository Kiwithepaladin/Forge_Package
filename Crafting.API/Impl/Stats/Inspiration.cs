using Crafting.Core.Abstract.Stat;


namespace Crafting.API.Impl.Stats
{
    public sealed class Inspiration : NumericStat
    {
        public override float MAX_VALUE => 100;
        public override float WEIGHT => 20;
    }
}
