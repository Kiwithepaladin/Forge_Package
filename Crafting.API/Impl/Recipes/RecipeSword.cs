using Crafting.API.Impl.Ingredients;
using Crafting.API.Impl.Items;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Abstract.Items;
using Crafting.Core.Abstract.Recipe;
using System.Collections.Generic;

namespace Crafting.API.Impl.Recipes
{
    public class RecipeSword : Recipe
    {
        protected override List<IComponent> Ingredient => new List<IComponent> {
            new Handle(), new Iron(), new Iron()
        };
        public override Item Item => new Sword();
        public override int Difficulty => 500;
    }
}
