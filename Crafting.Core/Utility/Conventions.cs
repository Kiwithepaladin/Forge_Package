using System;
using System.Collections.Generic;
using System.Text;

namespace Crafting.Core.Utility
{
    /// <summary>
    /// Quality of an Item
    /// </summary>
    public enum Quality
    {
        Unknown,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    /// <summary>
    /// Result indicates if the crafting was succesful or not
    /// </summary>
    public enum Result
    {
        Unknown,
        Successful,
        Failed,
    }
}
