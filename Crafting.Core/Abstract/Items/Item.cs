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
        public abstract int Difficulty { get; }

        public abstract Item Craft(Quality quality);

        private void SetQuality(Quality newQuality)
        {
            _quality = newQuality;
        }
    }
}
