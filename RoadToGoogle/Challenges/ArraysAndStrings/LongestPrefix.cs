using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];

            //we are going to iterate through every string in the array starting from the second one
            for (int i = 1; i < strs.Length; i++)
            {
                //indexof method reports the zero based index of the first occurence of a specific character, returns -1 if character is not found
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}
