using Crafting.API.Stats;
using Crafting.Core.Stat;
using Crafting.Core.Utility;
using NUnit.Framework;
using System;

namespace Crafting.API.Tests.BasicTests
{
    internal class StatsTests : BaseTests
    {
        private bool testingToggle = false;

        [Test]
        public void Stats_Validate()
        {
            Assert.Greater(sheet.Stats.Count, 0);
        }

        [Test]
        public void Stats_Inspiration_Inspired()
        {
            var knowladge = sheet.GetStat<Knowledge>();
            knowladge.Set(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.Set(inspire.MAX_VALUE);

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Inspiration_Uninspired()
        {
            var knowladge = sheet.GetStat<Knowledge>();
            knowladge.Set(0);
            var inspire = sheet.GetStat<Inspiration>();
            inspire.Set(false);

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreNotEqual(Quality.Uncommon, ouputItem[0].Quality);
        }

        [Test]
        public void Stats_Multicraft_Maxium()
        {
            var stat = sheet.GetStat<Multicraft>();

            stat.Set(stat.MAX_VALUE);

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Multicraft.MAX_MULTICRAFT + 1, ouputItem.Count);
        }

        [Test]
        public void Stats_Multicraft_Minimum()
        {
            var stat = sheet.GetStat<Multicraft>();
            stat.Set(0f);

            var ouputItem = table.Craft(recipe, Ingredient);

            Assert.AreEqual(1, ouputItem.Count);
        }

        [Test]
        public void Stats_StatSheet_SetValue_Equals()
        {
            var modifiedStat = sheet.SetStat<Multicraft, float>(10f);

            Assert.AreEqual(modifiedStat.Get(), 10f);
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

        [Test]
        public void Stats_Stat_Float_SetValue_Callback()
        {
            testingToggle = false;
            var stat = sheet.GetStat<Knowledge>();
            stat.OnValueChanged += Stat_Test_Callback;
            stat.Set(1);
            Assert.IsTrue(testingToggle);
            stat.OnValueChanged -= Stat_Test_Callback;
        }

        [Test]
        public void Stats_Stat_Float_SetValue_No_Callback()
        {
            testingToggle = false;
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(1);
            Assert.IsFalse(testingToggle);
        }

        #region Helper Methods
        private void Stat_Test_Callback(IStat stat)
        {
            testingToggle = true;
        }
        #endregion
    }
}