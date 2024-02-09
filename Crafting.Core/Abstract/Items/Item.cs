using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Items
{
    public abstract class Item : IComponent
    {
        public abstract string Name { get; }

        private Quality _quality;
        public Quality Quality { get => _quality; set => SetQuality(value); }

        public Item Craft(Quality quality)
        {
            var newItem = (Item)Activator.CreateInstance(GetType());
            newItem.Quality = quality;
            return newItem;
        }

        private void SetQuality(Quality newQuality)
        {
            _quality = newQuality;
        }
    }
}
