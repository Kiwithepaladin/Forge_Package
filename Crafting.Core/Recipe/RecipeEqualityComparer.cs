﻿using Crafting.Core.Components;
using System.Collections.Generic;

namespace Crafting.Core.Recipe
{
    internal class RecipeEqualityComparer : IEqualityComparer<IComponent>
    {
        public bool Equals(IComponent x, IComponent y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name.ToLower() == y.Name.ToLower() && x.GetType() == y.GetType();
        }

        public int GetHashCode(IComponent obj)
        {
            return obj.Name.GetHashCode() ^ obj.GetType().GetHashCode();
        }
    }
}
