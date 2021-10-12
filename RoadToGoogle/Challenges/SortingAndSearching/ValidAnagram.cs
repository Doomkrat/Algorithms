using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.SortingAndSearching
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var charArray = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                charArray[s[i]]++;
                charArray[t[i]]--;
            }

            return charArray.All(x => x == 0);
        }
    }
}
