using Crafting.API.Impl;
using Crafting.API.Impl.Items;
using Crafting.API.Impl.Stat;
using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Utility;
using NUnit.Framework;
using System.Linq;

namespace Crafting.Core.Tests
{
    internal class StatsTests
    {
        StatsSheet sheet;
        CraftingTable table;

        [SetUp]
        public void Setup()
        {
            sheet = new StatsSheet();
            table = new CraftingTable(sheet);
        }

        [Test]
        public void EnsureStatSheetIsNotEmpty()
        {
            Assert.Greater(sheet.Stats.Count, 0);
        }

        [Test]
        public void Craft_Inspiration_Inspired()
        {
            var knowladge = sheet.GetStat<Knowladge>();
            knowladge.SetValue(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(inspire.MAX_VALUE);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Inspiration_Uninspired()
        {
            var knowladge = sheet.GetStat<Knowladge>();
            knowladge.SetValue(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(0);

            var ouputItem = table.Craft(new Sword());

            Assert.AreNotEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Multicraft_Maxium()
        {
            var stat = sheet.GetStat<Multicraft>();

            stat.SetValue(stat.MAX_VALUE);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Multicraft.MAX_MULTICRAFT + 1, ouputItem.Count);
        }

        [Test]
        public void Craft_Multicraft_Minimum()
        {
            var stat = sheet.GetStat<Multicraft>();
            stat.SetValue(0);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(1, ouputItem.Count);
        }
    }
}