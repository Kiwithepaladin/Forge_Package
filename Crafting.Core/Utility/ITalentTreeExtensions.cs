using Crafting.Core.Abstract.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting.Core.Utility
{
    public static class ITalentTreeExtensions
    {
        public static ITalent FindTalent(this ITalentTree tree, ITalent root)
        {
            if (tree == null)
            {
                throw new ArgumentNullException();
            }

            if (root.Left != null)
            {
                tree.Talents.Add(FindTalent(tree, root.Left));
            }

            if (root.Right != null)
            {
                tree.Talents.Add(FindTalent(tree, root.Right));
            }

            return root;
        }

        public static void PrintTree(this ITalentTree tree)
        {
            if (tree == null)
            {
                throw new ArgumentNullException();
            }

            InOrderTraversal(tree.Talents.First());
        }

        private static void InOrderTraversal(ITalent root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.GetType() + " ");
                InOrderTraversal(root.Right);
            }
        }
    }
}
