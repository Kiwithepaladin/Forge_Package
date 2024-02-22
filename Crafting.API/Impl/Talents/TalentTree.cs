using Crafting.Core.Abstract.Stat;
using Crafting.Core.Abstract.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.API.Impl.Talents
{
    /// <summary>
    /// Implements ITalentTree and auto populates the hashset using ITalents from the assembly 
    /// </summary>
    public sealed class TalentTree : ITalentTree
    {
        public string Name => nameof(TalentTree);
        public HashSet<ITalent> Talents { get; private set; }

        public TalentTree()
        {
            Talents = new();

            foreach (Type talentType in AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(ITalent).IsAssignableFrom(p)))
            {
                if (talentType.IsInterface || talentType.IsAbstract)
                {
                    continue;
                }

                ITalent newTalent = (ITalent)Activator.CreateInstance(talentType);
                Talents.Add(newTalent);
            }
        }
    }
}
