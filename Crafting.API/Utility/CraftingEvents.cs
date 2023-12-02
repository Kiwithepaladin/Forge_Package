using Crafting.Core.Abstract.Items;
using System;
using System.Collections.Generic;

namespace Crafting.API.Utility
{
    public class CraftingEvents
    {
        public delegate void CraftedItem(List<Item> craftedItems);
        public static event CraftedItem OnCraftCompletion;

        public static void RaiseCraftedCompletion(List<Item> craftedItems)
        {
            OnCraftCompletion?.Invoke(craftedItems);
        }
    }
}
