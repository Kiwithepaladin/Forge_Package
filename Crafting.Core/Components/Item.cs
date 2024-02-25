using Crafting.Core.Utility;
using System;

namespace Crafting.Core.Components
{
    public abstract class Item : IComponent
    {
        public abstract string Name { get; }
        private Quality _quality;
        public Quality Quality { get => _quality; private set => _quality = value; }

        public Item Craft(Quality quality)
        {
            var newItem = (Item)Activator.CreateInstance(GetType());
            newItem.Quality = quality;
            return newItem;
        }
    }
}
