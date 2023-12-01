using Crafting.API.Impl;
using Crafting.API.Impl.Items;
using Crafting.API.Impl.Stat;
using Crafting.API.Impl.Stats;
using Crafting.Core.Utility;
using NUnit.Framework;

namespace Crafting.API.Tests.BasicTests
{
    internal class CraftingTests
    {
        StatsSheet sheet;
        CraftingTable table;

        [SetUp]
        public void Setup()
        {
            sheet = new StatsSheet();
            table = new CraftingTable(sheet);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(0);
        }

        [Test]
        public void Craft_Knowladge_Quality_Legendary_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(stat.MAX_VALUE);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Legendary, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Epic_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(80);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Epic, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Rare_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(60);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Rare, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Uncommon_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(40);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Common_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(0);

            var ouputItem = table.Craft(new Sword());

            Assert.AreEqual(Quality.Common, ouputItem[0].Quality);
        }
    }
}
