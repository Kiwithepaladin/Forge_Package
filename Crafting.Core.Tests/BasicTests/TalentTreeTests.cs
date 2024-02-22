using Crafting.API.Impl.Talents;
using Crafting.Core.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crafting.API.Tests.BasicTests
{
    internal class TalentTreeTests
    {
        [Test]
        public void BuildTalentTree_Greater_Then_One()
        {
            var talentTree = new TalentTree();
            talentTree.PrintTree();
            Assert.GreaterOrEqual(talentTree.Talents.Count, 1);
        }
    }
}
