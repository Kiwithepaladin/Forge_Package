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

        [SetUp]
        public void Setup()
        {
            recipeSword = new RecipeSword();
        }

        [Test]
        public void Recipe_Cratable_Successful()
        {
            var copiedList = new Ingredient[recipeSword.Ingredient.Count];
            recipeSword.Ingredient.CopyTo(copiedList);

            Assert.AreEqual(Result.Successful, recipeSword.Craftable(copiedList));
        }

        [Test]
        public void Recipe_Cratable_Fail()
        {
            var copiedList = new Ingredient[recipeSword.Ingredient.Count];

            Assert.AreEqual(Result.Failed, recipeSword.Craftable(copiedList));
        }

        [Test]
        public void Recipe_Item_Creation_Full()
        {
            var copiedList = new Ingredient[recipeSword.Ingredient.Count];
            recipeSword.Ingredient.CopyTo(copiedList);


        }
    }
}
