﻿using System;
using System.Collections.Generic;

namespace Crafting.Core.Abstract.Stat
{
    public interface IStatSheet
    {
        public HashSet<IStat> Stats { get; set; }
    }
}