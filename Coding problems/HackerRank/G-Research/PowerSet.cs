using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.HackerRank.G_Research
{
    static class PowerSet
    {
        static IEnumerable<ISet<int>> GetPowerSet(ISet<int> set)
        {
            int[] elements = set.ToArray();
            int numberOfSets = (int)Math.Pow(2, elements.Length);
            var sets = new List<ISet<int>>(numberOfSets);

            for (int i = 0; i < numberOfSets; i++)
            {
                var subset = new HashSet<int>();
                for (int e_i = 0; e_i < elements.Length; e_i++)
                {
                    if (((i >> e_i) & 1) == 1)
                    {
                        subset.Add(elements[e_i]);
                    }
                }
                sets.Add(subset);
            }
            return sets;
        }
    }
}
