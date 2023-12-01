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
        public abstract List<Ingredient> Ingredient { get; }
        public abstract Item Item { get; }

        public Result Craftable(IEnumerable<Ingredient> ingredients)
        {
            if (Ingredient.SequenceEqual(ingredients, new RecipeEqualityComparer()))
            {
                return Result.Successful;
            }
            return Result.Failed;
        }
    }
}
