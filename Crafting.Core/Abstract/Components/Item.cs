using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Components
{
    public abstract class Item : IComponent
    {
        public abstract string Name { get; }
        private Quality _quality;
        public Quality Quality { get => _quality; private set => _quality = value; }
        public abstract Difficulty Difficulty { get; }

        public Item Craft(Quality quality)
        {
            var newItem = (Item)Activator.CreateInstance(GetType());
            newItem.Quality = quality;
            return newItem;
        }
    }
}
