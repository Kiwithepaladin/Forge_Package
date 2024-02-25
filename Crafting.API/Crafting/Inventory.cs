using Crafting.API.Utility;
using Crafting.Core.Components;
using System.Collections.Generic;

namespace Crafting.API.Crafting
{
    public sealed class Inventory
    {
        public List<Item> Items { get; set; } = new();

        public Inventory()
        {
            CraftingEvents.OnCraftCompletion += CraftingEvents_OnCraftCompletion;
        }

        ~Inventory()
        {
            CraftingEvents.OnCraftCompletion -= CraftingEvents_OnCraftCompletion;
        }

        private void CraftingEvents_OnCraftCompletion(List<Item> craftedItems)
        {
            Items.AddRange(craftedItems);
        }
    }
}
