using Crafting.Core.Abstract.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Recipe
{
    internal class RecipeEqualityComparer : IEqualityComparer<Ingredient>
    {
        public bool Equals(Ingredient x, Ingredient y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name.ToLower() == y.Name.ToLower() && x.GetType() == y.GetType();
        }

        public int GetHashCode(Ingredient obj)
        {
            return obj.Name.GetHashCode() ^ obj.GetType().GetHashCode();
        }
    }
}
