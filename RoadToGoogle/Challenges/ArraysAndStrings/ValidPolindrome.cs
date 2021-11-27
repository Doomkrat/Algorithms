using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToGoogle.Challenges.ArraysAndStrings
{
    public static class ValidPolindrome
    {
        public static bool ValidPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return isPalindrome(s, i + 1, j) || isPalindrome(s, i, j - 1);
                }
                i++;
                j--;
            }

            return true;
        }

        private static bool isPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--])
                    return false;
            }
            return true;
        }
    }
}
