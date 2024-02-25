using Crafting.API.Ingredients;
using Crafting.API.Items;
using Crafting.Core.Components;
using Crafting.Core.Recipe;
using Crafting.Core.Utility;
using System.Collections.Generic;

namespace Crafting.API.Recipes
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
