using Crafting.API.Utility;
using Crafting.Core.Abstract.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Crafting
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
