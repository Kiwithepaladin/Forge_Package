using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Abstract.Talents
{
    public interface ITalent
    {
        public string Name { get; }
        public string Description { get; }
        public ITalent Left { get; }
        public ITalent Right { get; }
    }
}
