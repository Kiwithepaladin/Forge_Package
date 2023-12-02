using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Items
{
    public abstract class Item
    {
        private Quality _quality;
        public Quality Quality { get => _quality; set => SetQuality(value); }

        public Item Craft(Quality quality)
        {
            Quality = quality;
            return this;
        }

        private void SetQuality(Quality newQuality)
        {
            Quality = newQuality;
        }
    }
}
