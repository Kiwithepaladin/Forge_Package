using Crafting.API.Impl.Stats;
using Crafting.Core.Utility;
using NUnit.Framework;

namespace Crafting.API.Tests.BasicTests
{
    internal class CraftingTests : BaseTests
    {
        [SetUp]
        protected override void Setup()
        {
            base.Setup();
            var inspire = sheet.GetStat<Inspiration>();
            inspire.SetValue(0);
        }

        [Test]
        public void Craft_Knowladge_Quality_Legendary_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(stat.MAX_VALUE);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Legendary, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Epic_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(80);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Epic, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Rare_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(60);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Rare, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Uncommon_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(40);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Craft_Knowladge_Quality_Common_Item()
        {
            var stat = sheet.GetStat<Knowladge>();
            stat.SetValue(0);

            var ouputItem = table.Craft(recipe, ingredient);

            Assert.AreEqual(Quality.Common, ouputItem[0].Quality);
        }
    }
}
