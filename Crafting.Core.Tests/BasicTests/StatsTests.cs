using Crafting.API.Stats;
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
            var knowladge = sheet.GetStat<Knowledge>();
            knowladge.Value = 0;
            var inspire = sheet.GetStat<Inspiration>();
            inspire.Value = inspire.MAX_VALUE;

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Inspiration_Uninspired()
        {
            var knowladge = sheet.GetStat<Knowledge>();
            knowladge.Value = 0;
            var inspire = sheet.GetStat<Inspiration>();
            inspire.Value = false;

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreNotEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Multicraft_Maxium()
        {
            var stat = sheet.GetStat<Multicraft>();

            stat.Value = stat.MAX_VALUE;

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Multicraft.MAX_MULTICRAFT + 1, ouputItem.Count);
        }

        [Test]
        public void Stats_Multicraft_Minimum()
        {
            var stat = sheet.GetStat<Multicraft>();
            stat.Value = 0;

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(1, ouputItem.Count);
        }

        [Test]
        public void Stats_StatSheet_SetValue_Equals()
        {
            var modifiedStat = sheet.SetStat<Multicraft, float>(10f);

            Assert.AreEqual(modifiedStat.Value, 10f);
        }

        [Test]
        public void Stats_StatSheet_SetValue_NotEquals()
        {
            try
            {
                var modifiedStat = sheet.SetStat<Knowledge, float>(10);
            }
            catch (System.Exception)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}