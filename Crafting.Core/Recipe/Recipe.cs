using Crafting.Core.Abstract.Recipe;
using Crafting.Core.Components;
using Crafting.Core.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Crafting.Core.Recipe
{
    public abstract class Recipe
    {
        protected abstract List<IComponent> Ingredient { get; }
        public abstract Item Item { get; }
        public abstract Difficulty Difficulty { get; }

        public Result Craftable(IEnumerable<IComponent> ingredients)
        {
            if (ingredients is null || ingredients.Count() <= 0)
            {
                return Result.Failed;
            }

            if (Ingredient.SequenceEqual(ingredients, new RecipeEqualityComparer()))
            {
                return Result.Successful;
            }

            return Result.Failed;
        }
    }
}
