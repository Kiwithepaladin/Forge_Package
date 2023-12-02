using Crafting.Core.Abstract.Items;
using System;
using System.Collections.Generic;

namespace Crafting.API.Utility
{
    public class CraftingEvents
    {
        public delegate void CraftedItem(List<Item> craftedItems);
        public static event CraftedItem OnCraftCompletion;

        public delegate void MulticraftedItem();
        public static event MulticraftedItem OnItemMulticrafted;

        internal static void RaiseCraftedCompletion(List<Item> craftedItems)
        {
            OnCraftCompletion?.Invoke(craftedItems);
        }

        internal static void RaiseMulticraftedItem()
        {
            OnItemMulticrafted?.Invoke();
        }
    }
}
