using Crafting.API.Stats;
using Crafting.API.Utility;
using Crafting.Core.Components;
using Crafting.Core.Recipe;
using Crafting.Core.Stat;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;

namespace Crafting.API.Crafting
{
    public sealed class CraftingTable
    {
        private readonly IStatSheet StatSheet;
        private readonly Random random;

        public CraftingTable(IStatSheet stats)
        {
            StatSheet = stats;
            random = new Random();
        }

        public List<Item> Craft(Recipe recipe, IEnumerable<IComponent> ingredients)
        {
            List<Item> crafted = new();

            if (recipe.Craftable(ingredients) != Result.Successful)
            {
                CraftingEvents.RaiseCraftFailed(recipe.Item);
                return crafted;
            }

            int multicraftCount = 0;
            Inspiration inspired = null;
            bool resorceful = false;
            Knowledge knowledge = null;

            foreach (var stat in StatSheet.Stats)
            {
                switch (stat)
                {
                    case Multicraft:
                        multicraftCount = ProcessMulticraft(stat as Multicraft);
                        break;
                    case Inspiration:
                        inspired = stat as Inspiration;
                        break;
                    case Resourceful:
                        resorceful = ProcessResoureceful(stat as Resourceful);
                        break;
                    case Knowledge:
                        knowledge = stat as Knowledge;
                        break;
                }
            }

            for (int i = 0; i < multicraftCount + 1; i++)
            {
                crafted.Add(recipe.Item.Craft(DetermineQuality(recipe, knowledge, inspired)));

                if (inspired.Value)
                {
                    CraftingEvents.RaiseInspiredItem(recipe.Item, inspired);
                }
            }

            CraftingEvents.RaiseCraftedCompletion(crafted);
            return crafted;
        }

        //TODO - make a better quality deteminating algorithm
        private Quality DetermineQuality(Recipe recipe, Knowledge skillLevel, Inspiration inspired)
        {
            Quality output;

            output = skillLevel.Value switch
            {
                int n when n >= 100 => Quality.Legendary,
                int n when n >= 80 => Quality.Epic,
                int n when n >= 60 => Quality.Rare,
                int n when n >= 40 => Quality.Uncommon,
                _ => Quality.Common,
            };

            if (inspired.Value && (int)output < Enum.GetValues(typeof(Quality)).Length - 1)
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
                CraftingEvents.RaiseMulticraftedItem();
                randomNumber = random.Next(1, 100);
                multicraftedCount++;
            }

            return multicraftedCount;
        }

        private bool ProcessResoureceful(Resourceful stat)
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
