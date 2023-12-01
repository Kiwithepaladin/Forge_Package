using Crafting.API.Impl.Ingredients;
using Crafting.API.Impl.Items;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Abstract.Items;
using Crafting.Core.Abstract.Recipe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.API.Impl.Recipes
{
    public class RecipeSword : Recipe
    {
        protected override List<Ingredient> Ingredient => new List<Ingredient> {
            new Iron(), new Iron(), new Iron()
        };

        public override Item Item => new Sword();
    }
}
