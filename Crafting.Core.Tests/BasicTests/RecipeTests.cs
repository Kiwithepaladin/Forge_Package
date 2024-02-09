using Crafting.API.Impl.Ingredients;
using Crafting.API.Impl.Items;
using Crafting.API.Impl.Recipes;
using Crafting.Core.Abstract.Ingredients;
using Crafting.Core.Utility;
using NUnit.Framework;
using System.Collections.Generic;

namespace Crafting.API.Tests.BasicTests
{
    internal class RecipeTests
    {
        RecipeSword recipeSword;
        private List<IComponent> ingredient => new List<IComponent> {
            new Handle(), new Iron(), new Iron()
        };

        [SetUp]
        public void Setup()
        {
            recipeSword = new RecipeSword();
        }

        [Test]
        public void Recipe_Cratable_Successful()
        {
            Assert.AreEqual(Result.Successful, recipeSword.Craftable(ingredient));
        }

        [Test]
        public void Recipe_Cratable_Fail()
        {
            Assert.AreEqual(Result.Failed, recipeSword.Craftable(null));
        }
    }
}
