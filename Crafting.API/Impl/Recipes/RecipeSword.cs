using Crafting.API.Impl.Ingredients;
using Crafting.API.Impl.Items;
using Crafting.Core.Abstract.Components;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Abstract.Recipe;
using Crafting.Core.Utility;
using System.Collections.Generic;

namespace Crafting.API.Impl.Recipes
{
    public sealed class RecipeSword : Recipe
    {
        protected override List<IComponent> Ingredient => new()
        {
            new Handle(), new Iron(), new Iron()
        };

        public override Item Item => new Sword();
        public override Difficulty Difficulty => Difficulty.Medium;
    }
}
