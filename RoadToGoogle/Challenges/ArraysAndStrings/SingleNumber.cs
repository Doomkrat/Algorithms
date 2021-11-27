using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class SingleNumber
    {
        //find a number which has single occurence in the array
        public static int singleNumber(int[] nums)
        {
            Dictionary<int, int> uniques = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!uniques.ContainsKey(num))
                {
                    uniques.Add(num, 1);
                }
                else
                {
                    uniques[num] += 1;
                }
            }

            foreach (int key in uniques.Keys)
            {
                if (uniques[key] == 1) return key;
            }
            return -1;
        }
    }
}
