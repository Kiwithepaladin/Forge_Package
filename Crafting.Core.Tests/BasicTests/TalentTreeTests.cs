using Crafting.API.Impl.Talents;
using Crafting.Core.Abstract.Talents;
using NUnit.Framework;
using System;
using System.Linq;

namespace Crafting.API.Tests.BasicTests
{
    internal class TalentTreeTests
    {   
        [Test]
        public void BuildTalentTree_Greater_Then_One()
        {
            var talentTree = new TalentTree();
            Assert.GreaterOrEqual(talentTree.Talents.Count, 1);
        }

        [Test]
        public void UseTalentTree_Apply_Points()
        {
            var talentTree = new TalentTree();
            var findTalent = talentTree.Talents.Where((s) => s.GetType() == typeof(Crafter)).FirstOrDefault();
            findTalent.OnUnlock += OnUnlocked_For_Tests;
            
            if (findTalent != null)
            {
                findTalent.ApplyPoints(findTalent.MAX_POINTS);
                Assert.IsTrue(findTalent.Unlocked);
            }
            else
            {
                Assert.Fail();
            }
        }

        private void OnUnlocked_For_Tests(ITalent talent)
        {
            Console.WriteLine(talent.Name);
        }
    }
}
