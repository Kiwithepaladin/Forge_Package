using Crafting.API.Impl.Stats;
using Crafting.Core.Abstract.Components;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;

namespace Crafting.API.Utility
{
    public sealed class CraftingEvents
    {
        public delegate void CraftedItem(List<Item> craftedItems);
        public static event CraftedItem OnCraftCompletion;

        public delegate void MulticraftedItem();
        public static event MulticraftedItem OnItemMulticrafted;

        public delegate void InspiredItem(Item inspiredItem);
        public static event InspiredItem OnInspiredItemCrafted;

        public delegate void CraftFailed(Result result);
        public static event CraftFailed OnCraftFailed;

        internal static void RaiseCraftedCompletion(List<Item> craftedItems)
        {
            OnCraftCompletion?.Invoke(craftedItems);
        }

        internal static void RaiseMulticraftedItem()
        {
            OnItemMulticrafted?.Invoke();
        }

        internal static void RaiseInspiredItem(Item inspiredItem, Inspiration inspiration)
        {
            inspiration.SetValue(false);
            OnInspiredItemCrafted?.Invoke(inspiredItem);
        }

        internal static void RaiseCraftFailed(Result result)
        {
            OnCraftFailed?.Invoke(result);
        }
    }
}
