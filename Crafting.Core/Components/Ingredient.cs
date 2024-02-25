using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Components
{
    public abstract class Ingredient : IComponent
    {
        public abstract string Name { get; }
    }
}
