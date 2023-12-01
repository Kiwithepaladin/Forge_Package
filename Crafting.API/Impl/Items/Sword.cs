using Crafting.Core.Abstract.Items;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Items
{
    public sealed class Sword : Item
    {
        public override int Difficulty => 500;

        public override Item Craft(Quality quality)
        {
            var newItem = new Sword();
            newItem.Quality = quality;
            return newItem;
        }
    }
}
