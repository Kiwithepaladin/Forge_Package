using Crafting.Core.Abstract.Talents;
using System;

namespace Crafting.Core.Utility
{
    public static class ITalentTreeExtensions
    {
        /// <summary>
        /// Constructs a ItalentTree based on a given ITalent thats acts as root,
        /// Going left to right recursively
        /// </summary>
        /// <param name="talentTree">The Talent Tree that is Being Constructed Into</param>
        /// <param name="rootTalent">The Root Talent in which the tree is built from</param>
        /// <returns>Final ITalent</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITalent ConstructTreeFromRoot(this ITalentTree talentTree, ITalent rootTalent)
        {
            if (talentTree == null)
            {
                throw new ArgumentNullException();
            }

            if (talentTree.Talents.Count == 0)
            {
                talentTree.Talents.Add(rootTalent);
            }

            if (rootTalent.Left != null)
            {
                talentTree.Talents.Add(ConstructTreeFromRoot(talentTree, rootTalent.Left));
            }

            if (rootTalent.Right != null)
            {
                talentTree.Talents.Add(ConstructTreeFromRoot(talentTree, rootTalent.Right));
            }

            return rootTalent;
        }
    }
}
