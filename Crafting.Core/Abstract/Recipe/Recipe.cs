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
        protected abstract List<IComponent> Ingredient { get; }
        public abstract Item Item { get; }
        public abstract int Difficulty { get; }

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
