using Crafting.Core.Abstract.Items;
using Crafting.Core.Impl.Stat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Utility
{
    internal sealed class CraftingUtility
    {
        public static Quality CalculateCraftingQuality(Item template, StatsSheet statsSheet)
        {
            Random random = new Random();
            int craftingMod = random.Next(0, 100);
            Quality output = Quality.Unknown;
            float allStats = new float();

            foreach (var stat in statsSheet.Stats)
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

            return output; 
        }
    }
}
