using Crafting.API.Impl;
using Crafting.API.Impl.Ingredients;
using Crafting.API.Impl.Recipes;
using Crafting.API.Impl.Stat;
using Crafting.Core.Abstract.Ingredients;
using NUnit.Framework;
using System.Collections.Generic;

namespace Crafting.API.Tests.BasicTests
{
    internal abstract class BaseTests
    {
        protected StatsSheet sheet;
        protected CraftingTable table;
        protected RecipeSword recipe;
        protected List<Ingredient> ingredient => new List<Ingredient> {
            new Iron(), new Iron(), new Iron()
        };

        [SetUp]
        protected virtual void Setup()
        {
            sheet = new StatsSheet();
            table = new CraftingTable(sheet);
            recipe = new RecipeSword();
        }
    }
}
