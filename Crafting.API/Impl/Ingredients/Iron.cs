using Crafting.Core.Abstract.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Ingredients
{
    public sealed class Iron : Ingredient
    {
        public override string Name => nameof(Iron);
    }
}
