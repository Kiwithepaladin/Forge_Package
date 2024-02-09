﻿using Crafting.Core.Abstract.Components;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Utility;
using System.Collections.Generic;
using System.Linq;

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
