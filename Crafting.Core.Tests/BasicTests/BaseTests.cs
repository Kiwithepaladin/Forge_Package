using Crafting.API.Crafting;
using Crafting.API.Ingredients;
using Crafting.API.Items;
using Crafting.API.Recipes;
using Crafting.API.Stats;
using Crafting.Core.Components;
using NUnit.Framework;
using System.Collections.Generic;

namespace Crafting.API.Tests.BasicTests
{
    internal abstract class BaseTests
    {
        protected StatsSheet sheet;
        protected CraftingTable table;
        protected RecipeSword recipe;
        protected static List<IComponent> Ingredient => [
            new Handle(), new Iron(), new Iron()
        ];

        [SetUp]
        protected virtual void Setup()
        {
            sheet = new StatsSheet();
            table = new CraftingTable(sheet);
            recipe = new RecipeSword();
        }
    }
}
