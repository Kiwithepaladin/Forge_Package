using Crafting.API.Impl.Stats;
using Crafting.API.Utility;
using Crafting.Core.Abstract.Components;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Abstract.Recipe;
using Crafting.Core.Abstract.Stat;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;

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

        public List<Item> Craft(Recipe recipe, IEnumerable<IComponent> ingredients)
        {
            List<Item> crafted = new List<Item>();
            
            if (recipe.Craftable(ingredients) != Result.Successful)
            {
                CraftingEvents.RaiseCraftedCompletion(crafted);
                return crafted;
            }

            int multicraftCount = 0;
            int knowledge = 0;
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
                    case Stats.Knowledge:
                        knowledge = ProcessKnowledge(stat as Knowledge);
                        break;
                }
            }

            for (int i = 0; i < multicraftCount; i++)
            {
                crafted.Add(recipe.Item.Craft(DetermineQuality(knowledge, inspired)));
            }

            crafted.Add(recipe.Item.Craft(DetermineQuality(knowledge, inspired)));

            CraftingEvents.RaiseCraftedCompletion(crafted);
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
                CraftingEvents.RaiseMulticraftedItem();
                randomNumber = random.Next(1, 100);
                multicraftedCount++;
            }

            return multicraftedCount;
        }

        private int ProcessKnowledge(Knowledge knowladge)
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
                CraftingEvents.RaiseInspiredItem();
                return true;
            }

            return false;
        }
    }
}
