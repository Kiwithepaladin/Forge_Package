using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Items;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl
{
    public sealed class CraftingTable
    {
        private IStatSheet StatSheet;
        private Random random;

        public CraftingTable(IStatSheet stats)
        {
            StatSheet = stats;
            random = new Random();
        }

        public List<Item> Craft(Item template)
        {
            List<Item> crafted = new List<Item>(1);
            Quality output = Quality.Unknown;
            int multicraftCount = 0;
            int knowladge = 0;
            bool resorceful = false;
            bool inspired = false;

            foreach (var stat in StatSheet.Stats)
            {
                switch (stat)
                {
                    case Multicraft:
                        multicraftCount = ProcessMulticraft(stat as Multicraft);
                        break;
                    case Inspiration:
                        inspired = ProcessInspiration(stat as Inspiration);
                        break;
                    case Resourceful:
                        resorceful = ProcessResoureceful(stat as Resourceful);
                        break;
                    case Knowladge:
                        knowladge = ProcessKnowladge(stat as Knowladge);
                        break;
                }
            }

            for (int i = 0; i < multicraftCount; i++)
            {
                crafted.Add(template.Craft(DetermineQuality(knowladge, inspired)));
            }

            crafted.Add(template.Craft(DetermineQuality(knowladge, inspired)));

            return crafted;
        }

        private Quality DetermineQuality(int skillLevel, bool inspired)
        {
            Quality output = Quality.Unknown;

            switch (skillLevel)
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

            if (inspired && (int)output < Enum.GetValues(typeof(Quality)).Length - 1)
            {
                return output += 1;
            }

            return output;
        }

        private int ProcessMulticraft(Multicraft stat)
        {
            int randomNumber = random.Next(1, 100);
            int multicraftedCount = 0;
            
            while (stat.Percentage() >= randomNumber && Multicraft.MAX_MULTICRAFT > multicraftedCount)
            {
                randomNumber = random.Next(1, 100);
                multicraftedCount++;
            }

            return multicraftedCount;
        }

        private int ProcessKnowladge(Knowladge knowladge)
        {
            return (int)Math.Ceiling(knowladge.Value);
        }

        private bool ProcessResoureceful(Resourceful stat)
        {
            int randomNumber = random.Next(0, 100);

            if (stat.Percentage() >= randomNumber)
            {
                return true;
            }

            return false;
        }

        private bool ProcessInspiration(Inspiration stat)
        {
            int randomNumber = random.Next(1, 100);

            if (stat.Percentage() >= randomNumber)
            {
                return true;
            }
            return false;
        }
    }
}
