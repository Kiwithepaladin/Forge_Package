using Crafting.Core.Abstract.Items;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Impl.Stat;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract
{
    public sealed class CraftingTable
    {
        private StatsSheet StatSheet;

        public CraftingTable(StatsSheet stats)
        {
            StatSheet = stats;
        }

        //TODO - Actually write an algorithm here
        public Item Craft(Item template)
        {
            Random random = new Random();
            int craftingMod = random.Next(0, 100);
            Quality output = Quality.Unknown;
            float allStats = new float();

            foreach (var stat in StatSheet.Stats)
            {
                allStats += stat.Percentage();
            }

            //TODO - replace with a stat
            int finalSkill = craftingMod + ((int)Math.Ceiling(allStats));

            switch (finalSkill)
            {
                case int n when (n >= 100):
                    output = Quality.Legendary;
                    break;
                case int n when (n >= 80):
                    output = Quality.Epic;
                    break;
                case int n when (n >= 60):
                    output = Quality.Rare;
                    break;
                case int n when (n >= 40):
                    output = Quality.Uncommon;
                    break;
                default:
                    output = Quality.Common;
                    break;
            }

            return template.Craft(output);
        }
    }
}
