﻿using Crafting.API.Crafting;
using Crafting.API.Stats;
using Crafting.Core.Stat;
using Crafting.Core.Utility;
using NUnit.Framework;

namespace Crafting.API.Tests.BasicTests
{
    internal class CraftingTests : BaseTests
    {
        private Inventory inventory;

        [SetUp]
        protected override void Setup()
        {
            base.Setup();
            inventory = new Inventory();
        }

        [Test]
        public void Craft_Knowledge_Quality_Legendary_Item()
        {
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(stat.MAX_VALUE);

            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Legendary, ouputItems[0].Quality);
        }

        [Test]
        public void Craft_Knowledge_Quality_Epic_Item()
        {
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(80);

            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Epic, ouputItems[0].Quality);
        }

        [Test]
        public void Craft_Knowledge_Quality_Rare_Item()
        {
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(60);

            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Rare, ouputItems[0].Quality);
        }

        [Test]
        public void Craft_Knowledge_Quality_Uncommon_Item()
        {
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(40);

            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Uncommon, ouputItems[0].Quality);
        }

        [Test]
        public void Craft_Knowledge_Quality_Common_Item()
        {
            var stat = sheet.GetStat<Knowledge>();
            stat.Set(0);

            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.AreEqual(Quality.Common, ouputItems[0].Quality);
        }

        [Test]
        public void Craft_Inventory_Items_Equals()
        {
            var ouputItems = table.Craft(recipe, Ingredient);

            Assert.GreaterOrEqual(inventory.Items.Count, ouputItems.Count);
        }
    }
}
