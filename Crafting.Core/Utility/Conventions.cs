﻿namespace Crafting.Core.Utility
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
        Failed
    }

    /// <summary>
    /// Difficulty of a Recipe, the lower the Difficulty is the higher the chance of creating a better item
    /// </summary>
    public enum Difficulty
    {
        Unknown,
        Easy,
        Medium,
        Hard,
        Extreme
    }
}
