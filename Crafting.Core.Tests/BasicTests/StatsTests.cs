using Crafting.API.Impl.Stats;
using Crafting.Core.Utility;
using NUnit.Framework;

namespace Crafting.API.Tests.BasicTests
{
    internal class StatsTests : BaseTests
    {
        [Test]
        public void Stats_Validate()
        {
            Assert.Greater(sheet.Stats.Count, 0);
        }

        [Test]
        public void Stats_Inspiration_Inspired()
        {
            var knowladge = sheet.GetStat<knowledge>();
            knowladge.SetValue(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(inspire.MAX_VALUE);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Inspiration_Uninspired()
        {
            var knowladge = sheet.GetStat<knowledge>();
            knowladge.SetValue(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(0);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreNotEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Multicraft_Maxium()
        {
            var stat = sheet.GetStat<Multicraft>();

            stat.SetValue(stat.MAX_VALUE);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Multicraft.MAX_MULTICRAFT + 1, ouputItem.Count);
        }

        [Test]
        public void Stats_Multicraft_Minimum()
        {
            var stat = sheet.GetStat<Multicraft>();
            stat.SetValue(0);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(1, ouputItem.Count);
        }
    }
}