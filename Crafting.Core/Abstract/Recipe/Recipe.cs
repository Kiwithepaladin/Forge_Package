using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Abstract.Items;
using Crafting.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.Core.Abstract.Recipe
{
    public abstract class Recipe
    {
        protected abstract List<Ingredient> Ingredient { get; }
        public abstract Item Item { get; }

        public Result Craftable(IEnumerable<Ingredient> ingredients)
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
