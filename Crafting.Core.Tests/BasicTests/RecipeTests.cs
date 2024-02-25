using Crafting.API.Recipes;
using Crafting.Core.Utility;
using NUnit.Framework;

namespace Crafting.API.Tests.BasicTests
{
    internal class RecipeTests : BaseTests
    {
        RecipeSword recipeSword;

        [SetUp]
        protected override void Setup()
        {
            base.Setup();
            recipeSword = new RecipeSword();
        }

        [Test]
        public void Recipe_Cratable_Successful()
        {
            Assert.AreEqual(Result.Successful, recipeSword.Craftable(Ingredient));
        }

        [Test]
        public void Recipe_Cratable_Fail()
        {
            Assert.AreEqual(Result.Failed, recipeSword.Craftable(null));
        }
    }
}
