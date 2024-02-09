using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Ingredients
{
    public abstract class Ingredient : IComponent
    {
        public abstract string Name { get; }
    }
}
